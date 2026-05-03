using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSoftwareVersionGetRequest.
    /// 
    /// Replaced by: SystemSoftwareVersionGetResponseRI in AS data mode
    /// <see cref="SystemSoftwareVersionGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:16560""}]")]
    public class SystemSoftwareVersionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _version;

        [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:16560")]
        public string Version
        {
            get => _version;
            set
            {
                VersionSpecified = true;
                _version = value;
            }
        }

        [XmlIgnore]
        protected bool VersionSpecified { get; set; }

    }
}
