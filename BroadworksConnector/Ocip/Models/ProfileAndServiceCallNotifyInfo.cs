using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Call Notify service
    /// 
    /// The criteria table's column headings are: "Is Active",
    /// "Criteria Name", "Time Schedule", "Calls From", "Blacklisted" ,"Holiday Schedule"
    /// 
    /// The "Calls From" column is a string containing call numbers
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4333""}]")]
    public class ProfileAndServiceCallNotifyInfo
    {

        protected string _callNotifyEmailAddress;

        [XmlElement(ElementName = "callNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4333")]
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
        protected bool CallNotifyEmailAddressSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4333")]
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
        protected bool CriteriaTableSpecified { get; set; }

    }
}
