using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPushNotificationAllowedApplicationGetListRequest.
    /// Contains a table with a row for each allowed push notification application with columns:
    /// "Application Id", "Description"
    /// <see cref="SystemPushNotificationAllowedApplicationGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13702""}]")]
    public class SystemPushNotificationAllowedApplicationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _applicationTable;

        [XmlElement(ElementName = "applicationTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13702")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ApplicationTable
        {
            get => _applicationTable;
            set
            {
                ApplicationTableSpecified = true;
                _applicationTable = value;
            }
        }

        [XmlIgnore]
        public bool ApplicationTableSpecified { get; set; }

    }
}
