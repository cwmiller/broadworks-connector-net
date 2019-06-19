using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest.
    /// Contains a list of number ranges that are assigned to an enterprise and still available for assignment to users within the enterprise.
    /// The column headings are "Number Range Start", "Number Range End" and "Is Active".
    /// <see cref="EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:156""}]")]
    public class EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _availableNumberRangeTable;

        [XmlElement(ElementName = "availableNumberRangeTable", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:156")]
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
        public bool AvailableNumberRangeTableSpecified { get; set; }

    }
}
