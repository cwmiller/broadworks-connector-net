using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest.
    /// Contains a list of number ranges that are assigned to a group and still available for assignment to users within the group.
    /// The column headings are "Number Range Start", "Number Range End" ,"Is Active" and “Extension Length”..
    /// <see cref="GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:364""}]")]
    public class GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableNumberRangeTable;

        [XmlElement(ElementName = "availableNumberRangeTable", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:364")]
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
