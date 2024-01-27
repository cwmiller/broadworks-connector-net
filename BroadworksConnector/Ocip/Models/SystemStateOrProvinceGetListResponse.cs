using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a 2 column table with column headings 'Key' and 'Display Name' and a row
    /// for each state or province.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18092""}]")]
    public class SystemStateOrProvinceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _stateOrProvinceTable;

        [XmlElement(ElementName = "stateOrProvinceTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18092")]
        public BroadWorksConnector.Ocip.Models.C.OCITable StateOrProvinceTable
        {
            get => _stateOrProvinceTable;
            set
            {
                StateOrProvinceTableSpecified = true;
                _stateOrProvinceTable = value;
            }
        }

        [XmlIgnore]
        protected bool StateOrProvinceTableSpecified { get; set; }

    }
}
