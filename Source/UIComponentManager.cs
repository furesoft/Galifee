using Avalonia.Collections;
using Avalonia.Controls;
using Galifee.Core.Interfaces;
using System.Collections.ObjectModel;

namespace Galifee
{
    public static class UIComponentManager
    {
        private static Carousel _carousel;

        public static void SetIsCarousel(Carousel target, bool carousel)
        {
            if (carousel)
            {
                _carousel = target;
            }
        }

        public static bool GetIsCarousel(Control target)
        {
            return target is Carousel;
        }

        public static void RegisterComponent(IVisualComponent component)
        {
            var items = (AvaloniaList<object>)_carousel.Items;

            items.Add(component.GetVisualControl(Runtime.Context));
        }
    }
}