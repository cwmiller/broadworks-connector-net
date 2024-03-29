using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest. Contains a list of available number ranges not yet assigned to any group.
    /// The column headings are "Number Range Start", "Number Range End","Is Active" and "Extension Length".
    /// <see cref="ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:680""}]")]
    public class ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableNumberRangeTable;

        [XmlElement(ElementName = "availableNumberRangeTable", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:680")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableNumberRangeTable
        {
            get => _availableNumberRangeTable;
            set
            {
                AvailableNumberRangeTableSpecified = true;
                _availableNumberRangeTable = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableNumberRangeTableSpecified { get; set; }

    }
}
