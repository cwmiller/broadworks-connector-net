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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15020""}]")]
    public class SystemPushNotificationAllowedApplicationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _applicationTable;

        [XmlElement(ElementName = "applicationTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15020")]
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
        protected bool ApplicationTableSpecified { get; set; }

    }
}
