using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkServerSyncParametersGetListRequest.
    /// Contains a list of system Network Server Sync parameters.
    /// <see cref="SystemNetworkServerSyncParametersGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5256""}]")]
    public class SystemNetworkServerSyncParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableSync;

        [XmlElement(ElementName = "enableSync", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5256")]
        public bool EnableSync
        {
            get => _enableSync;
            set
            {
                EnableSyncSpecified = true;
                _enableSync = value;
            }
        }

        [XmlIgnore]
        public bool EnableSyncSpecified { get; set; }

    }
}
