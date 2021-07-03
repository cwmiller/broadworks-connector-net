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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:956""}]")]
    public class SystemOutgoingCallingPlanCallTypeGetMappingListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _callTypeMapping;

        [XmlElement(ElementName = "callTypeMapping", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:956")]
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
