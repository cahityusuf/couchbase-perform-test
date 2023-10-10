namespace cb_perform_test.Models
{
    public class ResultModel<T> where T : class
    {
        public string component { get; set; } = null;
        public T data { get; set; } = null;
        public int dataCount { get; set; } = 0;
        public int errorCode { get; set; } = 0;
        public bool isLocked { get; set; } = false;
        public string key { get; set; } = null;
        public string message { get; set; } = null;
        public int paymentAction { get; set; } = 0;
        public string returnUrl { get; set; } = null;
        public int status { get; set; } = 1;
        public int totalItemCount { get; set; } = 0;
    }
}
