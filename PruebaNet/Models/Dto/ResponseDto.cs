﻿namespace PruebaNet.Models.Dto
{
    public class ResponseDto
    {
        public object? Data { get; set; }
        public Boolean? isSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
