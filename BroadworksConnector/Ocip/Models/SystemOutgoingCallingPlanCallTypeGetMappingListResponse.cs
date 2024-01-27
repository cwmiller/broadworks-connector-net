using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOutgoingCallingPlanCallTypeGetMappingListRequest. The table columns are:
    /// "Country Code", "Digit Map" and "Call Type".
    /// <see cref="SystemOutgoingCallingPlanCallTypeGetMappingListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:955""}]")]
    public class SystemOutgoingCallingPlanCallTypeGetMappingListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _callTypeMapping;

        [XmlElement(ElementName = "callTypeMapping", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:955")]
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
