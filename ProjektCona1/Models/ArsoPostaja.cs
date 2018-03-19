using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektCona1.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class data
    {

        private string languageField;

        private string creditField;

        private string credit_urlField;

        private string image_urlField;

        private string suggested_pickupField;

        private byte suggested_pickup_periodField;

        private string webcam_url_baseField;

        private string icon_url_baseField;

        private string icon_formatField;

        private string docs_urlField;

        private string disclaimer_urlField;

        private string copyright_urlField;

        private string privacy_policy_urlField;

        private string managing_editorField;

        private string web_masterField;

        private string generatorField;

        private object meteosi_urlField;

        private string two_day_history_urlField;

        private dataMetData metDataField;

        private string idField;

        /// <remarks/>
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <remarks/>
        public string credit_url
        {
            get
            {
                return this.credit_urlField;
            }
            set
            {
                this.credit_urlField = value;
            }
        }

        /// <remarks/>
        public string image_url
        {
            get
            {
                return this.image_urlField;
            }
            set
            {
                this.image_urlField = value;
            }
        }

        /// <remarks/>
        public string suggested_pickup
        {
            get
            {
                return this.suggested_pickupField;
            }
            set
            {
                this.suggested_pickupField = value;
            }
        }

        /// <remarks/>
        public byte suggested_pickup_period
        {
            get
            {
                return this.suggested_pickup_periodField;
            }
            set
            {
                this.suggested_pickup_periodField = value;
            }
        }

        /// <remarks/>
        public string webcam_url_base
        {
            get
            {
                return this.webcam_url_baseField;
            }
            set
            {
                this.webcam_url_baseField = value;
            }
        }

        /// <remarks/>
        public string icon_url_base
        {
            get
            {
                return this.icon_url_baseField;
            }
            set
            {
                this.icon_url_baseField = value;
            }
        }

        /// <remarks/>
        public string icon_format
        {
            get
            {
                return this.icon_formatField;
            }
            set
            {
                this.icon_formatField = value;
            }
        }

        /// <remarks/>
        public string docs_url
        {
            get
            {
                return this.docs_urlField;
            }
            set
            {
                this.docs_urlField = value;
            }
        }

        /// <remarks/>
        public string disclaimer_url
        {
            get
            {
                return this.disclaimer_urlField;
            }
            set
            {
                this.disclaimer_urlField = value;
            }
        }

        /// <remarks/>
        public string copyright_url
        {
            get
            {
                return this.copyright_urlField;
            }
            set
            {
                this.copyright_urlField = value;
            }
        }

        /// <remarks/>
        public string privacy_policy_url
        {
            get
            {
                return this.privacy_policy_urlField;
            }
            set
            {
                this.privacy_policy_urlField = value;
            }
        }

        /// <remarks/>
        public string managing_editor
        {
            get
            {
                return this.managing_editorField;
            }
            set
            {
                this.managing_editorField = value;
            }
        }

        /// <remarks/>
        public string web_master
        {
            get
            {
                return this.web_masterField;
            }
            set
            {
                this.web_masterField = value;
            }
        }

        /// <remarks/>
        public string generator
        {
            get
            {
                return this.generatorField;
            }
            set
            {
                this.generatorField = value;
            }
        }

        /// <remarks/>
        public object meteosi_url
        {
            get
            {
                return this.meteosi_urlField;
            }
            set
            {
                this.meteosi_urlField = value;
            }
        }

        /// <remarks/>
        public string two_day_history_url
        {
            get
            {
                return this.two_day_history_urlField;
            }
            set
            {
                this.two_day_history_urlField = value;
            }
        }

        /// <remarks/>
        public dataMetData metData
        {
            get
            {
                return this.metDataField;
            }
            set
            {
                this.metDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMetData
    {

        private string domain_meteosiIdField;

        private uint domain_idField;

        private string domain_parentIdField;

        private string domain_countryIsoCode2Field;

        private decimal domain_latField;

        private decimal domain_lonField;

        private decimal domain_altitudeField;

        private string domain_titleField;

        private string domain_shortTitleField;

        private string domain_longTitleField;

        private string titleField;

        private string sunriseField;

        private string sunsetField;

        private string tsValid_issuedField;

        private string tsValid_issued_dayField;

        private string tsValid_issued_UTCField;

        private string tsValid_issued_RFC822Field;

        private string tsUpdatedField;

        private string tsUpdated_dayField;

        private string tsUpdated_UTCField;

        private string tsUpdated_RFC822Field;

        private string valid_dayField;

        private string validField;

        private string valid_UTCField;

        private string nn_iconField;

        private string nn_shortTextField;

        private string nn_decodeTextField;

        private string wwsyn_iconField;

        private string wwsyn_shortTextField;

        private string wwsyn_longTextField;

        private string nn_iconwwsyn_iconField;

        private string t_var_descField;

        private string t_var_unitField;

        private byte tField;

        private byte t_degreesCField;

        private string tw_var_descField;

        private string tw_var_unitField;

        private object twField;

        private string tnsyn_var_descField;

        private string tnsyn_var_unitField;

        private object tnsynField;

        private string txsyn_var_descField;

        private string txsyn_var_unitField;

        private object txsynField;

        private object windchillField;

        private byte vis_valueField;

        private string vis_unitField;

        private string rh_var_descField;

        private string rh_var_unitField;

        private byte rhField;

        private string td_var_descField;

        private string td_var_unitField;

        private sbyte tdField;

        private sbyte td_degreesCField;

        private string dd_var_descField;

        private string dd_var_unitField;

        private byte dd_valField;

        private string dd_iconField;

        private string dd_shortTextField;

        private string dd_longTextField;

        private string dd_decodeTextField;

        private string ddff_iconField;

        private string ff_var_descField;

        private string ff_var_unitField;

        private decimal ff_valField;

        private byte ff_val_kmhField;

        private byte ff_valueField;

        private byte ff_value_kmhField;

        private byte ff_minimumField;

        private byte ff_minimum_kmhField;

        private byte ff_maximumField;

        private byte ff_maximum_kmhField;

        private string ff_iconField;

        private string ffmax_var_descField;

        private string ffmax_var_unitField;

        private decimal ffmax_valField;

        private byte ffmax_val_kmhField;

        private string msl_var_descField;

        private string msl_var_unitField;

        private ushort mslField;

        private ushort msl_mbField;

        private string p_var_descField;

        private string p_var_unitField;

        private ushort pField;

        private ushort p_mbField;

        private string pa_var_descField;

        private object pa_var_unitField;

        private object pa_shortTextField;

        private string rr24h_var_descField;

        private string rr24h_var_unitField;

        private object rr24h_valField;

        private string snow_var_descField;

        private string snow_var_unitField;

        private object snowField;

        private string rrHh_var_descField;

        private string rrHh_var_unitField;

        private byte rrHhField;

        private string snowNew_var_descField;

        private string snowNew_var_unitField;

        private object snowNew_valField;

        private string domain_geoTypeField;

        private object noteField;

        /// <remarks/>
        public string domain_meteosiId
        {
            get
            {
                return this.domain_meteosiIdField;
            }
            set
            {
                this.domain_meteosiIdField = value;
            }
        }

        /// <remarks/>
        public uint domain_id
        {
            get
            {
                return this.domain_idField;
            }
            set
            {
                this.domain_idField = value;
            }
        }

        /// <remarks/>
        public string domain_parentId
        {
            get
            {
                return this.domain_parentIdField;
            }
            set
            {
                this.domain_parentIdField = value;
            }
        }

        /// <remarks/>
        public string domain_countryIsoCode2
        {
            get
            {
                return this.domain_countryIsoCode2Field;
            }
            set
            {
                this.domain_countryIsoCode2Field = value;
            }
        }

        /// <remarks/>
        public decimal domain_lat
        {
            get
            {
                return this.domain_latField;
            }
            set
            {
                this.domain_latField = value;
            }
        }

        /// <remarks/>
        public decimal domain_lon
        {
            get
            {
                return this.domain_lonField;
            }
            set
            {
                this.domain_lonField = value;
            }
        }

        /// <remarks/>
        public decimal domain_altitude
        {
            get
            {
                return this.domain_altitudeField;
            }
            set
            {
                this.domain_altitudeField = value;
            }
        }

        /// <remarks/>
        public string domain_title
        {
            get
            {
                return this.domain_titleField;
            }
            set
            {
                this.domain_titleField = value;
            }
        }

        /// <remarks/>
        public string domain_shortTitle
        {
            get
            {
                return this.domain_shortTitleField;
            }
            set
            {
                this.domain_shortTitleField = value;
            }
        }

        /// <remarks/>
        public string domain_longTitle
        {
            get
            {
                return this.domain_longTitleField;
            }
            set
            {
                this.domain_longTitleField = value;
            }
        }

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string sunrise
        {
            get
            {
                return this.sunriseField;
            }
            set
            {
                this.sunriseField = value;
            }
        }

        /// <remarks/>
        public string sunset
        {
            get
            {
                return this.sunsetField;
            }
            set
            {
                this.sunsetField = value;
            }
        }

        /// <remarks/>
        public string tsValid_issued
        {
            get
            {
                return this.tsValid_issuedField;
            }
            set
            {
                this.tsValid_issuedField = value;
            }
        }

        /// <remarks/>
        public string tsValid_issued_day
        {
            get
            {
                return this.tsValid_issued_dayField;
            }
            set
            {
                this.tsValid_issued_dayField = value;
            }
        }

        /// <remarks/>
        public string tsValid_issued_UTC
        {
            get
            {
                return this.tsValid_issued_UTCField;
            }
            set
            {
                this.tsValid_issued_UTCField = value;
            }
        }

        /// <remarks/>
        public string tsValid_issued_RFC822
        {
            get
            {
                return this.tsValid_issued_RFC822Field;
            }
            set
            {
                this.tsValid_issued_RFC822Field = value;
            }
        }

        /// <remarks/>
        public string tsUpdated
        {
            get
            {
                return this.tsUpdatedField;
            }
            set
            {
                this.tsUpdatedField = value;
            }
        }

        /// <remarks/>
        public string tsUpdated_day
        {
            get
            {
                return this.tsUpdated_dayField;
            }
            set
            {
                this.tsUpdated_dayField = value;
            }
        }

        /// <remarks/>
        public string tsUpdated_UTC
        {
            get
            {
                return this.tsUpdated_UTCField;
            }
            set
            {
                this.tsUpdated_UTCField = value;
            }
        }

        /// <remarks/>
        public string tsUpdated_RFC822
        {
            get
            {
                return this.tsUpdated_RFC822Field;
            }
            set
            {
                this.tsUpdated_RFC822Field = value;
            }
        }

        /// <remarks/>
        public string valid_day
        {
            get
            {
                return this.valid_dayField;
            }
            set
            {
                this.valid_dayField = value;
            }
        }

        /// <remarks/>
        public string valid
        {
            get
            {
                return this.validField;
            }
            set
            {
                this.validField = value;
            }
        }

        /// <remarks/>
        public string valid_UTC
        {
            get
            {
                return this.valid_UTCField;
            }
            set
            {
                this.valid_UTCField = value;
            }
        }

        /// <remarks/>
        public string nn_icon
        {
            get
            {
                return this.nn_iconField;
            }
            set
            {
                this.nn_iconField = value;
            }
        }

        /// <remarks/>
        public string nn_shortText
        {
            get
            {
                return this.nn_shortTextField;
            }
            set
            {
                this.nn_shortTextField = value;
            }
        }

        /// <remarks/>
        public string nn_decodeText
        {
            get
            {
                return this.nn_decodeTextField;
            }
            set
            {
                this.nn_decodeTextField = value;
            }
        }

        /// <remarks/>
        public string wwsyn_icon
        {
            get
            {
                return this.wwsyn_iconField;
            }
            set
            {
                this.wwsyn_iconField = value;
            }
        }

        /// <remarks/>
        public string wwsyn_shortText
        {
            get
            {
                return this.wwsyn_shortTextField;
            }
            set
            {
                this.wwsyn_shortTextField = value;
            }
        }

        /// <remarks/>
        public string wwsyn_longText
        {
            get
            {
                return this.wwsyn_longTextField;
            }
            set
            {
                this.wwsyn_longTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nn_icon-wwsyn_icon")]
        public string nn_iconwwsyn_icon
        {
            get
            {
                return this.nn_iconwwsyn_iconField;
            }
            set
            {
                this.nn_iconwwsyn_iconField = value;
            }
        }

        /// <remarks/>
        public string t_var_desc
        {
            get
            {
                return this.t_var_descField;
            }
            set
            {
                this.t_var_descField = value;
            }
        }

        /// <remarks/>
        public string t_var_unit
        {
            get
            {
                return this.t_var_unitField;
            }
            set
            {
                this.t_var_unitField = value;
            }
        }

        /// <remarks/>
        public byte t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
            }
        }

        /// <remarks/>
        public byte t_degreesC
        {
            get
            {
                return this.t_degreesCField;
            }
            set
            {
                this.t_degreesCField = value;
            }
        }

        /// <remarks/>
        public string tw_var_desc
        {
            get
            {
                return this.tw_var_descField;
            }
            set
            {
                this.tw_var_descField = value;
            }
        }

        /// <remarks/>
        public string tw_var_unit
        {
            get
            {
                return this.tw_var_unitField;
            }
            set
            {
                this.tw_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tw
        {
            get
            {
                return this.twField;
            }
            set
            {
                this.twField = value;
            }
        }

        /// <remarks/>
        public string tnsyn_var_desc
        {
            get
            {
                return this.tnsyn_var_descField;
            }
            set
            {
                this.tnsyn_var_descField = value;
            }
        }

        /// <remarks/>
        public string tnsyn_var_unit
        {
            get
            {
                return this.tnsyn_var_unitField;
            }
            set
            {
                this.tnsyn_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tnsyn
        {
            get
            {
                return this.tnsynField;
            }
            set
            {
                this.tnsynField = value;
            }
        }

        /// <remarks/>
        public string txsyn_var_desc
        {
            get
            {
                return this.txsyn_var_descField;
            }
            set
            {
                this.txsyn_var_descField = value;
            }
        }

        /// <remarks/>
        public string txsyn_var_unit
        {
            get
            {
                return this.txsyn_var_unitField;
            }
            set
            {
                this.txsyn_var_unitField = value;
            }
        }

        /// <remarks/>
        public object txsyn
        {
            get
            {
                return this.txsynField;
            }
            set
            {
                this.txsynField = value;
            }
        }

        /// <remarks/>
        public object windchill
        {
            get
            {
                return this.windchillField;
            }
            set
            {
                this.windchillField = value;
            }
        }

        /// <remarks/>
        public byte vis_value
        {
            get
            {
                return this.vis_valueField;
            }
            set
            {
                this.vis_valueField = value;
            }
        }

        /// <remarks/>
        public string vis_unit
        {
            get
            {
                return this.vis_unitField;
            }
            set
            {
                this.vis_unitField = value;
            }
        }

        /// <remarks/>
        public string rh_var_desc
        {
            get
            {
                return this.rh_var_descField;
            }
            set
            {
                this.rh_var_descField = value;
            }
        }

        /// <remarks/>
        public string rh_var_unit
        {
            get
            {
                return this.rh_var_unitField;
            }
            set
            {
                this.rh_var_unitField = value;
            }
        }

        /// <remarks/>
        public byte rh
        {
            get
            {
                return this.rhField;
            }
            set
            {
                this.rhField = value;
            }
        }

        /// <remarks/>
        public string td_var_desc
        {
            get
            {
                return this.td_var_descField;
            }
            set
            {
                this.td_var_descField = value;
            }
        }

        /// <remarks/>
        public string td_var_unit
        {
            get
            {
                return this.td_var_unitField;
            }
            set
            {
                this.td_var_unitField = value;
            }
        }

        /// <remarks/>
        public sbyte td
        {
            get
            {
                return this.tdField;
            }
            set
            {
                this.tdField = value;
            }
        }

        /// <remarks/>
        public sbyte td_degreesC
        {
            get
            {
                return this.td_degreesCField;
            }
            set
            {
                this.td_degreesCField = value;
            }
        }

        /// <remarks/>
        public string dd_var_desc
        {
            get
            {
                return this.dd_var_descField;
            }
            set
            {
                this.dd_var_descField = value;
            }
        }

        /// <remarks/>
        public string dd_var_unit
        {
            get
            {
                return this.dd_var_unitField;
            }
            set
            {
                this.dd_var_unitField = value;
            }
        }

        /// <remarks/>
        public byte dd_val
        {
            get
            {
                return this.dd_valField;
            }
            set
            {
                this.dd_valField = value;
            }
        }

        /// <remarks/>
        public string dd_icon
        {
            get
            {
                return this.dd_iconField;
            }
            set
            {
                this.dd_iconField = value;
            }
        }

        /// <remarks/>
        public string dd_shortText
        {
            get
            {
                return this.dd_shortTextField;
            }
            set
            {
                this.dd_shortTextField = value;
            }
        }

        /// <remarks/>
        public string dd_longText
        {
            get
            {
                return this.dd_longTextField;
            }
            set
            {
                this.dd_longTextField = value;
            }
        }

        /// <remarks/>
        public string dd_decodeText
        {
            get
            {
                return this.dd_decodeTextField;
            }
            set
            {
                this.dd_decodeTextField = value;
            }
        }

        /// <remarks/>
        public string ddff_icon
        {
            get
            {
                return this.ddff_iconField;
            }
            set
            {
                this.ddff_iconField = value;
            }
        }

        /// <remarks/>
        public string ff_var_desc
        {
            get
            {
                return this.ff_var_descField;
            }
            set
            {
                this.ff_var_descField = value;
            }
        }

        /// <remarks/>
        public string ff_var_unit
        {
            get
            {
                return this.ff_var_unitField;
            }
            set
            {
                this.ff_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal ff_val
        {
            get
            {
                return this.ff_valField;
            }
            set
            {
                this.ff_valField = value;
            }
        }

        /// <remarks/>
        public byte ff_val_kmh
        {
            get
            {
                return this.ff_val_kmhField;
            }
            set
            {
                this.ff_val_kmhField = value;
            }
        }

        /// <remarks/>
        public byte ff_value
        {
            get
            {
                return this.ff_valueField;
            }
            set
            {
                this.ff_valueField = value;
            }
        }

        /// <remarks/>
        public byte ff_value_kmh
        {
            get
            {
                return this.ff_value_kmhField;
            }
            set
            {
                this.ff_value_kmhField = value;
            }
        }

        /// <remarks/>
        public byte ff_minimum
        {
            get
            {
                return this.ff_minimumField;
            }
            set
            {
                this.ff_minimumField = value;
            }
        }

        /// <remarks/>
        public byte ff_minimum_kmh
        {
            get
            {
                return this.ff_minimum_kmhField;
            }
            set
            {
                this.ff_minimum_kmhField = value;
            }
        }

        /// <remarks/>
        public byte ff_maximum
        {
            get
            {
                return this.ff_maximumField;
            }
            set
            {
                this.ff_maximumField = value;
            }
        }

        /// <remarks/>
        public byte ff_maximum_kmh
        {
            get
            {
                return this.ff_maximum_kmhField;
            }
            set
            {
                this.ff_maximum_kmhField = value;
            }
        }

        /// <remarks/>
        public string ff_icon
        {
            get
            {
                return this.ff_iconField;
            }
            set
            {
                this.ff_iconField = value;
            }
        }

        /// <remarks/>
        public string ffmax_var_desc
        {
            get
            {
                return this.ffmax_var_descField;
            }
            set
            {
                this.ffmax_var_descField = value;
            }
        }

        /// <remarks/>
        public string ffmax_var_unit
        {
            get
            {
                return this.ffmax_var_unitField;
            }
            set
            {
                this.ffmax_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal ffmax_val
        {
            get
            {
                return this.ffmax_valField;
            }
            set
            {
                this.ffmax_valField = value;
            }
        }

        /// <remarks/>
        public byte ffmax_val_kmh
        {
            get
            {
                return this.ffmax_val_kmhField;
            }
            set
            {
                this.ffmax_val_kmhField = value;
            }
        }

        /// <remarks/>
        public string msl_var_desc
        {
            get
            {
                return this.msl_var_descField;
            }
            set
            {
                this.msl_var_descField = value;
            }
        }

        /// <remarks/>
        public string msl_var_unit
        {
            get
            {
                return this.msl_var_unitField;
            }
            set
            {
                this.msl_var_unitField = value;
            }
        }

        /// <remarks/>
        public ushort msl
        {
            get
            {
                return this.mslField;
            }
            set
            {
                this.mslField = value;
            }
        }

        /// <remarks/>
        public ushort msl_mb
        {
            get
            {
                return this.msl_mbField;
            }
            set
            {
                this.msl_mbField = value;
            }
        }

        /// <remarks/>
        public string p_var_desc
        {
            get
            {
                return this.p_var_descField;
            }
            set
            {
                this.p_var_descField = value;
            }
        }

        /// <remarks/>
        public string p_var_unit
        {
            get
            {
                return this.p_var_unitField;
            }
            set
            {
                this.p_var_unitField = value;
            }
        }

        /// <remarks/>
        public ushort p
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        public ushort p_mb
        {
            get
            {
                return this.p_mbField;
            }
            set
            {
                this.p_mbField = value;
            }
        }

        /// <remarks/>
        public string pa_var_desc
        {
            get
            {
                return this.pa_var_descField;
            }
            set
            {
                this.pa_var_descField = value;
            }
        }

        /// <remarks/>
        public object pa_var_unit
        {
            get
            {
                return this.pa_var_unitField;
            }
            set
            {
                this.pa_var_unitField = value;
            }
        }

        /// <remarks/>
        public object pa_shortText
        {
            get
            {
                return this.pa_shortTextField;
            }
            set
            {
                this.pa_shortTextField = value;
            }
        }

        /// <remarks/>
        public string rr24h_var_desc
        {
            get
            {
                return this.rr24h_var_descField;
            }
            set
            {
                this.rr24h_var_descField = value;
            }
        }

        /// <remarks/>
        public string rr24h_var_unit
        {
            get
            {
                return this.rr24h_var_unitField;
            }
            set
            {
                this.rr24h_var_unitField = value;
            }
        }

        /// <remarks/>
        public object rr24h_val
        {
            get
            {
                return this.rr24h_valField;
            }
            set
            {
                this.rr24h_valField = value;
            }
        }

        /// <remarks/>
        public string snow_var_desc
        {
            get
            {
                return this.snow_var_descField;
            }
            set
            {
                this.snow_var_descField = value;
            }
        }

        /// <remarks/>
        public string snow_var_unit
        {
            get
            {
                return this.snow_var_unitField;
            }
            set
            {
                this.snow_var_unitField = value;
            }
        }

        /// <remarks/>
        public object snow
        {
            get
            {
                return this.snowField;
            }
            set
            {
                this.snowField = value;
            }
        }

        /// <remarks/>
        public string rrHh_var_desc
        {
            get
            {
                return this.rrHh_var_descField;
            }
            set
            {
                this.rrHh_var_descField = value;
            }
        }

        /// <remarks/>
        public string rrHh_var_unit
        {
            get
            {
                return this.rrHh_var_unitField;
            }
            set
            {
                this.rrHh_var_unitField = value;
            }
        }

        /// <remarks/>
        public byte rrHh
        {
            get
            {
                return this.rrHhField;
            }
            set
            {
                this.rrHhField = value;
            }
        }

        /// <remarks/>
        public string snowNew_var_desc
        {
            get
            {
                return this.snowNew_var_descField;
            }
            set
            {
                this.snowNew_var_descField = value;
            }
        }

        /// <remarks/>
        public string snowNew_var_unit
        {
            get
            {
                return this.snowNew_var_unitField;
            }
            set
            {
                this.snowNew_var_unitField = value;
            }
        }

        /// <remarks/>
        public object snowNew_val
        {
            get
            {
                return this.snowNew_valField;
            }
            set
            {
                this.snowNew_valField = value;
            }
        }

        /// <remarks/>
        public string domain_geoType
        {
            get
            {
                return this.domain_geoTypeField;
            }
            set
            {
                this.domain_geoTypeField = value;
            }
        }

        /// <remarks/>
        public object note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
    }


}