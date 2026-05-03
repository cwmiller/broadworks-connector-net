using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSoftwareVersionGetRequestRI.
    /// 
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// releaseAnchor
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18290""}]")]
    public class SystemSoftwareVersionGetResponseRI : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _version;

        [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18290")]
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

        protected string _releaseAnchor;

        [XmlElement(ElementName = "releaseAnchor", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18290")]
        public string ReleaseAnchor
        {
            get => _releaseAnchor;
            set
            {
                ReleaseAnchorSpecified = true;
                _releaseAnchor = value;
            }
        }

        [XmlIgnore]
        protected bool ReleaseAnchorSpecified { get; set; }

    }
}
