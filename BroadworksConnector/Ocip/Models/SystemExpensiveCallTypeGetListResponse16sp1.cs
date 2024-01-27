using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemExpensiveCallTypeGetListRequest16sp1.
    /// The column headings are:
    /// "Alternate Call Indicator", "Treatment Audio File".
    /// <see cref="SystemExpensiveCallTypeGetListRequest16sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10012""}]")]
    public class SystemExpensiveCallTypeGetListResponse16sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _alternateCallIndicatorTable;

        [XmlElement(ElementName = "alternateCallIndicatorTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10012")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AlternateCallIndicatorTable
        {
            get => _alternateCallIndicatorTable;
            set
            {
                AlternateCallIndicatorTableSpecified = true;
                _alternateCallIndicatorTable = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateCallIndicatorTableSpecified { get; set; }

    }
}
