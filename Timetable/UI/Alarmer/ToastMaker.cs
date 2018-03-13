using Microsoft.QueryStringDotNET;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Alarmer
{
    public static class ToastMaker
    {
        public static ToastVisual GetVisual(Bus bus)
        {
            return new ToastVisual()
            {
                BindingGeneric = new ToastBindingGeneric()
                {
                    Children =
                    {
                        new AdaptiveText()
                        {
                            Text = "Dude, Where's My Bus?"
                        },

                        new AdaptiveText()
                        {
                            Text = bus.Departing
                        }
                    }
                }
            };
        }
    }
}
