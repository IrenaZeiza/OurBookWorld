using System;

namespace OurBookWorld.UI.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public string ErrorMessage { get; set; }

        public string SuccessMessage { get; set; }


        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public bool ShowErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        public bool ShowSuccessMessage => !string.IsNullOrEmpty(SuccessMessage);

    }
}
