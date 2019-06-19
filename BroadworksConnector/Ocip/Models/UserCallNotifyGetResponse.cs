using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallNotifyGetRequest. The criteria table's column headings are: "Is Active",
    /// "Criteria Name", "Time Schedule", "Calls From", "Blacklisted" ,"Holiday Schedule", "Calls To Type", "Calls To Number" and "Calls To Extension".
    /// The following columns are only returned in AS data mode:
    /// "Calls To Type", "Calls To Number" and "Calls To Extension"
    /// 
    /// The possible values for the "Calls To Type" column are the following or a combination of them separated by comma:
    /// - Primary
    /// - Alternate X (where x is a number between 1 and 10)
    /// - Mobility
    /// The possible values for the "Calls To Number" column are the following or a combination of them separated by comma:
    /// - The value of the phone number for the corresponding Calls To Type, when the number is available. i.e. Alternate 1 may have extension, but no number.
    /// - When no number is available a blank space is provided instead.
    /// The possible values for the "Calls To Extension" column are the following or a combination of them separated by comma:
    /// - The value of the extension for the corresponding Calls To Type, when the extension is available. i.e. Primary may have number, but no extension.
    /// - For Mobility Calls To Type, this is always blank.
    /// - When no extension is available a blank space is provided instead.
    /// <see cref="UserCallNotifyGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""26f62134ab1693f4bdddc7c70b20d2eb:257""}]")]
    public class UserCallNotifyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _callNotifyEmailAddress;

        [XmlElement(ElementName = "callNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"26f62134ab1693f4bdddc7c70b20d2eb:257")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CallNotifyEmailAddress
        {
            get => _callNotifyEmailAddress;
            set
            {
                CallNotifyEmailAddressSpecified = true;
                _callNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool CallNotifyEmailAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"26f62134ab1693f4bdddc7c70b20d2eb:257")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable
        {
            get => _criteriaTable;
            set
            {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaTableSpecified { get; set; }

    }
}
