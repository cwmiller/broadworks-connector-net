using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Network Class of Service.
    /// The response is either a SystemNetworkClassOfServiceGetResponse17
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemNetworkClassOfServiceGetRequest19sp1 in AS data mode
    /// <see cref="SystemNetworkClassOfServiceGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemNetworkClassOfServiceGetRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10696""}]")]
    public class SystemNetworkClassOfServiceGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemNetworkClassOfServiceGetResponse17>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10696")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

    }
}
