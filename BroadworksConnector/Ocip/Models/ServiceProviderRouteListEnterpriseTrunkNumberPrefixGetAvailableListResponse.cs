using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest.
    /// Contains a list of available number prefixes not yet assigned to any group.
    /// The column headings are "Number Prefix" and "Is Active".
    /// <see cref="ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:519""}]")]
    public class ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _availableNumberPrefixTable;

        [XmlElement(ElementName = "availableNumberPrefixTable", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:519")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableNumberPrefixTable
        {
            get => _availableNumberPrefixTable;
            set
            {
                AvailableNumberPrefixTableSpecified = true;
                _availableNumberPrefixTable = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableNumberPrefixTableSpecified { get; set; }

    }
}
