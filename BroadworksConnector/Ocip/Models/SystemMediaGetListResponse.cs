using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaGetListRequest. The column headings are
    /// "Media Name", "Codec", "Media Type", "Bandwidth Enforcement Type" and "Bandwidth".
    /// <see cref="SystemMediaGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11813""}]")]
    public class SystemMediaGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _mediaTable;

        [XmlElement(ElementName = "mediaTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11813")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MediaTable
        {
            get => _mediaTable;
            set
            {
                MediaTableSpecified = true;
                _mediaTable = value;
            }
        }

        [XmlIgnore]
        protected bool MediaTableSpecified { get; set; }

    }
}
