using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebVanGia.Models
{
	public class SliderModel
    {
        public int vangia_id_silde { get; set; }
        public string vangia_noidung_silde { get; set; }
        public string vangia_tomtat_silde { get; set; }
        public string vangia_img_silde { get; set; }
        public string vangia_name_silde { get; set; }
        public Nullable<int> vangia_status_silde { get; set; }
        public Nullable<int> vangia_order_silde { get; set; }
        public Nullable<int> vangia_language_silde { get; set; }
        public string vangia_link_silde { get; set; }
        public string vangia_stype_slide { get; set; }
        public Nullable<int> vangia_type_slide { get; set; }
        public string vangia_img_id
        {
            get
            {
                var regex = new Regex(@"^(?<id>\d+).*$");
                var match = regex.Match(vangia_img_silde);

                if (match.Success)
                {
                    return match.Groups["id"].Value;
                }
                return null;
            }
        }
    }
}
