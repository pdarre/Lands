namespace Lands.Models
{
    using System;

    public class Response
    {
        public bool IsSuccess { get; set; }
        public String Message { get; set; }
        public Object Result { get; set; }
    }
}
