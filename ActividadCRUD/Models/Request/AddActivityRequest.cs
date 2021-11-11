using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ActividadCRUD.Models.Request
{
    [ExcludeFromCodeCoverage]
    [DataContract(Namespace = "")]
    public class AddActivityRequest
    {
        [Required]
        [DataMember]
        public int property_id { get; set; }
        [Required]
        [DataMember]
        public DateTime schedule { get; set; }
        [Required]
        [DataMember]
        public string title { get; set; }
        [Required]
        [DataMember]
        public string status { get; set; }
    }
}
