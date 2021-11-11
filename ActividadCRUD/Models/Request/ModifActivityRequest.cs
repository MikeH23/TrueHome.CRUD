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
    public class ModifActivityRequest
    {
        [Required]
        [DataMember]
        public int id { get; set; }
        [Required]
        [DataMember]
        public DateTime? schedule { get; set; }
    }
}
