using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemTimeZoneGetListRequest20.
    /// Contains the configured time zone of the server processing the request and
    /// contains a 2 column table with column headings 'Key' and 'Display Name' and a row
    /// for each time zone.
    /// <see cref="SystemTimeZoneGetListRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18832""}]")]
    public class SystemTimeZoneGetListResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serverTimeZone;

        [XmlElement(ElementName = "serverTimeZone", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18832")]
        [MinLength(1)]
        [MaxLength(127)]
        public string ServerTimeZone
        {
            get => _serverTimeZone;
            set
            {
                ServerTimeZoneSpecified = true;
                _serverTimeZone = value;
            }
        }

        [XmlIgnore]
        protected bool ServerTimeZoneSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _timeZoneTable;

        [XmlElement(ElementName = "timeZoneTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18832")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TimeZoneTable
        {
            get => _timeZoneTable;
            set
            {
                TimeZoneTableSpecified = true;
                _timeZoneTable = value;
            }
        }

        [XmlIgnore]
        protected bool TimeZoneTableSpecified { get; set; }

    }
}
