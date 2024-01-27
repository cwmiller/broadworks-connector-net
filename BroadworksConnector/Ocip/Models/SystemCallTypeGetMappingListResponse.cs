using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallTypeGetMappingListRequest. The table columns are:
    /// "Country Code", "Digit Map", "Call Type" and "Ignore AS Emergency Route".
    /// The following column is returned only in AS Mode:
    /// "Ignore AS Emergency Route"
    /// <see cref="SystemCallTypeGetMappingListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5342""}]")]
    public class SystemCallTypeGetMappingListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _callTypeMapping;

        [XmlElement(ElementName = "callTypeMapping", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5342")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallTypeMapping
        {
            get => _callTypeMapping;
            set
            {
                CallTypeMappingSpecified = true;
                _callTypeMapping = value;
            }
        }

        [XmlIgnore]
        protected bool CallTypeMappingSpecified { get; set; }

    }
}
