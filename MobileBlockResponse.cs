﻿namespace Avalanche
{
    public class MobileBlockResponse
    {
        public MobileBlockResponse()
        {
            Response = "";
            TTL = 0;
        }
        public string Arg { get; set; }
        public string Response { get; set; }
        public int TTL { get; set; }
    }
}