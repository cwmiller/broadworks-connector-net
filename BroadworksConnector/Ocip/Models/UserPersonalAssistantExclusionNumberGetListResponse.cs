using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPersonalAssistantExclusionNumberGetListRequest.
    /// Contains a table with column headings:
    /// "Number", "Description".
    /// <see cref="UserPersonalAssistantExclusionNumberGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f53ece1c00394ef2d3d76f532f9a9663:234""}]")]
    public class UserPersonalAssistantExclusionNumberGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _exclusionNumberTable;

        [XmlElement(ElementName = "exclusionNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:234")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ExclusionNumberTable
        {
            get => _exclusionNumberTable;
            set
            {
                ExclusionNumberTableSpecified = true;
                _exclusionNumberTable = value;
            }
        }

        [XmlIgnore]
        protected bool ExclusionNumberTableSpecified { get; set; }

    }
}
