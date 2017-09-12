using System;

namespace Quartz.MojangApi
{
    public sealed class PlayerProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Property[] Properties { get; set; }
        
        public sealed class Property
        {
            public string Name { get; set; }
            public string Value { get; set; }
            /// <summary>
            /// Can be null
            /// </summary>
            public string Signature { get; set; }

            public bool IsSigned => Signature != null;
        }
    }
}
