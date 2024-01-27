using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLicensingGetRequest. The license table columns are: "Name", "Licensed", "Used",
    /// "Available" and "Expiration Date".
    /// Replaced By: SystemLicensingGetResponse14sp3
    /// <see cref="SystemLicensingGetRequest"/>
    /// <see cref="SystemLicensingGetResponse14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27933""}]")]
    public class SystemLicensingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.LicenseStrictness _licenseStrictness;

        [XmlElement(ElementName = "licenseStrictness", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:27933")]
        public BroadWorksConnector.Ocip.Models.LicenseStrictness LicenseStrictness
        {
            get => _licenseStrictness;
            set
            {
                LicenseStrictnessSpecified = true;
                _licenseStrictness = value;
            }
        }

        [XmlIgnore]
        protected bool LicenseStrictnessSpecified { get; set; }

        protected int _groupUserlimit;

        [XmlElement(ElementName = "groupUserlimit", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:27933")]
        [MinInclusive(1)]
        public int GroupUserlimit
        {
            get => _groupUserlimit;
            set
            {
                GroupUserlimitSpecified = true;
                _groupUserlimit = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserlimitSpecified { get; set; }

        protected string _expirationDate;

        [XmlElement(ElementName = "expirationDate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:27933")]
        public string ExpirationDate
        {
            get => _expirationDate;
            set
            {
                ExpirationDateSpecified = true;
                _expirationDate = value;
            }
        }

        [XmlIgnore]
        protected bool ExpirationDateSpecified { get; set; }

        protected List<string> _hostId = new List<string>();

        [XmlElement(ElementName = "hostId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:27933")]
        [MinLength(1)]
        public List<string> HostId
        {
            get => _hostId;
            set
            {
                HostIdSpecified = true;
                _hostId = value;
            }
        }

        [XmlIgnore]
        protected bool HostIdSpecified { get; set; }

        protected List<string> _licenseName = new List<string>();

        [XmlElement(ElementName = "licenseName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:27933")]
        [MinLength(1)]
        public List<string> LicenseName
        {
            get => _licenseName;
            set
            {
                LicenseNameSpecified = true;
                _licenseName = value;
            }
        }

        [XmlIgnore]
        protected bool LicenseNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _licenseTable;

        [XmlElement(ElementName = "licenseTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:27933")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LicenseTable
        {
            get => _licenseTable;
            set
            {
                LicenseTableSpecified = true;
                _licenseTable = value;
            }
        }

        [XmlIgnore]
        protected bool LicenseTableSpecified { get; set; }

    }
}
