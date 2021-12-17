using Microsoft.AspNetCore.Components;
using OfflineBlazor.Data;

namespace OfflineBlazor.Pages
{
    public partial class FillTheForm: ComponentBase
    {
        [Parameter]
        public Address Address { get; set; }


        /// <summary>
        /// Message juts for demo purpose. This message is to replace proper form processing (e.g. saving to database)
        /// </summary>
        private string AfterSubmitMessage { get; set; }

        protected override void OnInitialized()
        {
            if (Address == null)
            {
                Address = new Address()
                {
                    Street = "Lovel Close 3",
                    City = "Roayl on Themes",
                    PostCode = "RG97RS",
                    State = "Kingdom of People",
                };
            }
            base.OnInitialized();
        }

        private void HandleValidSubmit()
        {
            //Logger.LogInformation("HandleValidSubmit called");
            AfterSubmitMessage = $"Thank you for filling the form. We will send youthe goods to the address:{Address}";
        }
    }
}
