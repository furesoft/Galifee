using Avalonia.Collections;
using Avalonia.Controls;
using Galifrei.Core.Interfaces;

namespace Galifrei
{
    public static class UIComponentManager
    {
        private static Carousel _carousel;

        public static void SetIsCarousel(Carousel target, bool carousel)
        {
            if (carousel)
            {
                _carousel = target;

                //add controls to carousel after initialisation
                foreach (var component in Runtime.Context.Components)
                {
                    UIComponentManager.RegisterComponent(component);
                }
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