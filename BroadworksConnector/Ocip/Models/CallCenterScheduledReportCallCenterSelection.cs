using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Either all call centers or list of call centers.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7623""}]")]
    public class CallCenterScheduledReportCallCenterSelection
    {

        private bool _allCallCenter;

        [XmlElement(ElementName = "allCallCenter", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7623")]
        public bool AllCallCenter
        {
            get => _allCallCenter;
            set
            {
                AllCallCenterSpecified = true;
                _allCallCenter = value;
            }
        }

        [XmlIgnore]
        protected bool AllCallCenterSpecified { get; set; }

        private List<string> _serviceUserId = new List<string>();

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7623")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

    }
}
