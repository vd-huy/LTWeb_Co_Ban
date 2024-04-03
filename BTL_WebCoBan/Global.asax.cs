using BTL_WebCoBan.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_WebCoBan
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            /*Data User*/
            List<objects.user> users = new List<objects.user>();
            users.Add(new objects.user("Huy", "Vũ", "0964129650", "nhokvip004@gmail.com", "123456"));
            Application["users"] = users;

            /*Data Product*/
            List<objects.product> products = new List<objects.product>();
            products.Add(new objects.product(1, "Natural Core Thịt gà và Phô mai 40gr cho mèo",
                "Natural Core Thịt gà và Phô mai 40gr cho mèo được làm hoàn toàn từ nguyên liệu tự nhiên, cung cấp nguồn dinh dưỡng an toàn cho sức khoẻ của thú cưng.\r\n\r\n- Sử dụng nguồn nguyên liệu sạch đạt tiêu chuẩn dành cho người.\r\n- Thịt gà tươi chứa hàm lượng protein cao, ít chất béo, hỗ trợ phát triển cơ bắp và xương khớp.\r\n- Làm từ phô mai tươi, thịt tươi với tiêu chuẩn như thức ăn của người.\r\n- Chứa hàm lượng taurine cao, tốt cho thị lực và tim mạch.\r\n- Bổ sung DHA và omega 3 và 6 hỗ trợ da lông\r\n\r\nXuất xứ: Hàn Quốc",
                "https://product.hstatic.net/200000263355/product/z5293235651169_61677a0f509e4042d02afe94bc91f2fc_891da09db1af45dbbcfdb33d0b16312f_master.jpg",
                45000,
                "Natural Core",
                10));

            products.Add(new objects.product(2, "Cat Tree - Trụ mèo cào Lạc đà",
                "CAT TREE hay còn gọi là nhà cây cho mèo, có thể hiểu như một ngôi nhà, một sân chơi, một phòng tập thể hình dành cho Mèo yêu tận hưởng những giây phút thư giãn, giải trí. Mèo có thể ngủ 14 tiếng một ngày trong cat tree, chơi đùa không biết mệt mỏi với những món đồ lúc lắc treo trên đỉnh tháp hoặc có thể leo lên leo xuống như bạn tập trên máy chạy bộ.\r\nGiúp Mèo giảm được những nguy cơ mắc các bệnh béo phì, chán ăn hoặc bị stress do lười vận động hoặc không có ai chơi đùa cùng chúng.",
                "https://product.hstatic.net/200000263355/product/z5276828014035_2e2aa92507b24531cc46de38000c4e88_30c660cfbfdf4e0aa259445097c9eb10_master.jpg",
                495000,
                "Khác",
                0));

            products.Add(new objects.product(3, "Kệ sắt tai mèo chén sứ đôi",
                "NHÀ SẠCH THÌ MÁT - BÁT SẠCH ĂN NHÌU\r\n- Chén ăn Sứ cao cấp Elite cho cún miu đã nhiều mẫu, nay còn về mới nhiều mẫu nữa cho các sen chọn hoa mắt luôn ạ.\r\n- Chén ăn Elite cầm chắc tay nhưng không quá nặng, nhiều kích thước, màu sắc nhã nhặn tinh tế\r\n- Ngoài ăn ngon, các sen nhớ mua cả chén đẹp cho các bé nữa nhé",
                "https://product.hstatic.net/200000263355/product/z5276829105453_37f208fcb3408cf817a1c513ec92610e_d50a35481fbe47f499821ec9a660de19_master.jpg",
                225000,
                "Khác",
                0));

            products.Add(new objects.product(4, "Áo BÔNG mini size thú nổi Petstyle",
                "Khách có thể inbox chọn màu mỗi mẫu, shop sẽ ưu tiên gửi khách đúng màu nếu kho còn, nếu kho hết shop xin phép giao màu ngẫu nhiên ạ ❤\r\nKhách có thể để lại sđt để shop tiện liên hệ nhé\r\n\r\nBạn inbox cho shop giống cún, mèo và cân nặng, tụi mình tư vấn size để bạn đặt hàng cho đúng nhé ❤",
                "https://product.hstatic.net/200000263355/product/z5276834257318_b52ac7c93d49712e5400317bef8fb26a_6fdec2ceb5be4764a09ccd081f3a6fdb_master.jpg",
                60000,
                "Natural Core",
                20));

            products.Add(new objects.product(5, "Bánh quy Catnip hộp 80gr cho mèo",
                "Thông tin sản phẩm:\r\nBánh quy Catnip là món ăn vặt mê hoặc các bé mèo cưng, với hương vị thơm ngon của cá hồi cùng catnip giúp bảo vệ sức khỏe răng miệng, làm giảm mảng bám và đẩy lùi mùi hôi từ miệng bé.\r\n\r\nBánh quy làm từ nguyên liệu tự nhiên, vitamin, khoáng chất và các chất dinh dưỡng khác, không có hương vị nhân tạo.\r\n\r\nQuy cách: Hộp 80gr\r\n\r\nBảo quản: nơi khô mát, tránh ánh nắng trực tiếp, đậy kín nắp sau khi sử dụng.",
                "https://product.hstatic.net/200000263355/product/z5276838012316_b2452242b7ca05331a53f0ed86fb522b_653156ced5ae4ae181b55b3d54718984_master.jpg",
                35000,
                "Natural Core",
                10));

            products.Add(new objects.product(6, "Xúc xích dinh dưỡng Taotaopet cho chó mèo",
                "Xúc xích dinh dưỡng cho chó Taotaopet chứa Vitamin & khoáng chất cho cơ thể những thú cưng luôn khỏe mạnh, linh hoạt. Chất xơ cho hệ thống tiêu hóa tốt, tăng cường khả năng hấp thu chất dinh dưỡng, góp phần vào sự phát triển đồng đều cho thú cưng\r\n\r\n-          Nguyên liệu tươi tự nhiên chất lượng cao, tất cả các nguyên liệu được kiểm tra nghiêm ngặt\r\n\r\n-          Giúp ổn định hệ thống vi khuẩn đường ruột, tiêu hóa khỏe, bé ăn ngon",
                "https://product.hstatic.net/200000263355/product/z5276832024158_3e67204eac17d1212fead151a85aa916_df52acc674c74fa695aa3d4c092a9eb6_master.jpg",
                58000,
                "Khác",
                10));

            products.Add(new objects.product(7, "Áo ba lỗ cotton trái cây Petstyle",
                "Khách có thể inbox chọn màu mỗi mẫu, shop sẽ ưu tiên gửi khách đúng màu nếu kho còn, nếu kho hết shop xin phép giao màu ngẫu nhiên ạ \r\n❤ Khách có thể để lại sđt để shop tiện liên hệ nhé \r\n\r\nBạn inbox cho shop giống cún, mèo và cân nặng, tụi mình tư vấn size để bạn đặt hàng cho đúng ạ ",
                "https://product.hstatic.net/200000263355/product/z5276836343297_58bb4c59d6cba639921a4bb8c313c844_fd12a29f68ac4a6ca0d68675eeb2686d_master.jpg",
                120000,
                "Natural Core",
                20));

            products.Add(new objects.product(8, "Bộ Kit trồng cỏ mèo thủy canh",
                "Bộ Kit trồng cỏ mèo thủy canh giúp cung cấp chất xơ, tiêu và loại bỏ búi lông, hỗ trợ đường tiêu hóa cho mèo\r\n\r\nQuy cách đóng gói: 1 bộ gồm 1 khay và 5 túi hạt.",
                "https://product.hstatic.net/200000263355/product/z5276826511325_2700b415b2e840a1ae93a2a0aa79ea85_4eea34e412b8454aa03d6d5ad6529416_master.jpg",
                42000,
                "Natural Core",
                10));

            products.Add(new objects.product(9, "Súp thưởng Aatas 16gr cho mèo",
                "Súp thưởng cho mèo Aatas Cream kem mềm mịn chứa hương vị mặn mòi của thịt gà được nuôi dưới mô hình chăn thả, cá hồi hoặc cá ngừ được đánh bắt tự nhiên giúp mượt lông , bổ sung dinh dưỡng cho các bé.\r\n\r\nSúp dạng kem mịn, đậm đặc siêu thơm ngon:\r\n- Vàng: Thịt gà\r\n- Hồng: Cá ngừ\r\n- Xanh dương: Cá hồi\r\n\r\nQuy cách: Gói 16gr\r\n\r\nBảo quản nơi khô ráo thoáng mát. Giữ lạnh khi mở bao bì.",
                "https://product.hstatic.net/200000263355/product/z5251200148172_788f87a7de7c38cfe2efcb1c57c7b184_46b410f824c449f5b3e6299d21a52282_master.jpg",
                10000,
                "Natural Core",
                10));

            products.Add(new objects.product(10, "Bộ yếm 2 dây kẻ caro Together",
                "Khách có thể inbox chọn màu mỗi mẫu, shop sẽ ưu tiên gửi khách đúng màu nếu kho còn, nếu kho hết shop xin phép giao màu ngẫu nhiên ạ ❤\r\nKhách có thể để lại sđt để shop tiện liên hệ nhé\r\n\r\nBạn inbox cho shop giống cún, mèo và cân nặng, tụi mình tư vấn size để bạn đặt hàng cho đúng nhé ❤",
                "https://product.hstatic.net/200000263355/product/z3888661979695_595bf937da85d2bbe276e3190a6de130_6d2afa8801944425a1439a76aea19370_master.jpg",
                165000,
                "Natural Core",
                50));

            products.Add(new objects.product(11, "Pate Ciao gói cho mèo",
                "Pate cho mèo Nhật Bản Ciao dạng súp gói 40g làm từ những nguyên liệu tươi ngon nhất từ biển cả: sò điệp hảo hạng sẽ kích thích vị giác của thú cưng, giúp chúng ăn ngon miệng hơn. Chất khoáng và các loại vitamin sẽ giúp cho mèo có hệ miễn dịch khoẻ mạnh.\r\n\r\nĐặc biệt, thành phần pate Ciao chứa chiết xuất trà xanh khiến cho mùi hôi của các tạp chất trong đường ruột và chất thải được giảm thiểu tối đa. Sản phẩm không chưa chất bảo quản, tuyệt đối an toàn với hệ tiêu hoá và sức khoẻ của mèo nhà bạn",
                "https://product.hstatic.net/200000263355/product/z3888661979695_595bf937da85d2bbe276e3190a6de130_6d2afa8801944425a1439a76aea19370_master.jpg",
                14000,
                "Ciao",
                10));

            products.Add(new objects.product(11, "Pate Ciao gói cho mèo",
                "Pate cho mèo Nhật Bản Ciao dạng súp gói 40g làm từ những nguyên liệu tươi ngon nhất từ biển cả: sò điệp hảo hạng sẽ kích thích vị giác của thú cưng, giúp chúng ăn ngon miệng hơn. Chất khoáng và các loại vitamin sẽ giúp cho mèo có hệ miễn dịch khoẻ mạnh.\r\n\r\nĐặc biệt, thành phần pate Ciao chứa chiết xuất trà xanh khiến cho mùi hôi của các tạp chất trong đường ruột và chất thải được giảm thiểu tối đa. Sản phẩm không chưa chất bảo quản, tuyệt đối an toàn với hệ tiêu hoá và sức khoẻ của mèo nhà bạn",
                "https://product.hstatic.net/200000263355/product/z5185521952787_e0b277247efee3ea3cace0ac25be50d9_3ecdf35b27a14696b0e6533413b1d1a9_master.jpg",
                14000,
                "Ciao",
                10));

            products.Add(new objects.product(12, "Royal Canin Pate Urinary S/O gói cho chó mèo",
                "Pate Cho Chó Royal Canin Urinary S/O là thức ăn dinh dưỡng hoàn chỉnh cho chó, được sản xuất bởi thương hiệu Royal Canin nổi tiếng thế giới. Với công thức đặc biệt, Royal Canin Urinary giúp hỗ trợ hòa tan sỏi Struvite và giảm tái phát nhờ các thành phần có thể axit hóa nước tiểu, ít chứa phân tử Magie (thành phần chính của sỏi Struvite).\r\n\r\n-Hỗ trợ hòa tan sỏi Struvite\r\n-Giảm nguy cơ tái phát sỏi thận Struvite\r\n-Duy trì cân bằng chất điện giải\r\n-Cung cấp đầy đủ dinh dưỡng cho chó trưởng thành",
                "https://product.hstatic.net/200000263355/product/z5094389450944_4b295a7a97b9ff6e8823f30eed0098d4_01d9aa9a047d4413a12d8709dfb66ddb_master.jpg",
                38000,
                "Royal Canin",
                30));

            products.Add(new objects.product(13, "Áo Ba lỗ Mickey Mouse",
               "Khách có thể inbox chọn màu mỗi mẫu, shop sẽ ưu tiên gửi khách đúng màu nếu kho còn, nếu kho hết shop xin phép giao màu ngẫu nhiên ạ ❤\r\nKhách có thể để lại sđt để shop tiện liên hệ nhé\r\n\r\nBạn inbox cho shop giống cún, mèo và cân nặng, tụi mình tư vấn size để bạn đặt hàng cho đúng nhé ❤",
               "https://product.hstatic.net/200000263355/product/z5119529920893_57d1381b9a352c3fb6105220cd6d7f99_b449894e729045519a43e0625df7c9ae_master.jpg",
               165000,
               "Royal Canin",
               20));

            products.Add(new objects.product(14, "Thẻ tên inox dành cho Thú cưng",
               "Chưa có mô tả cho sản phẩm này",
               "https://product.hstatic.net/200000263355/product/568ca5b1-c395-423a-a8dd-bba7f53959ca_fc19499f14f24a5594931ff69b000b41_master.jpg",
               120000,
               "Royal Canin",
               26));

            products.Add(new objects.product(15, "Thẻ tên kim loại cho Thú cưng",
               "Chưa có mô tả cho sản phẩm này",
               "https://product.hstatic.net/200000263355/product/z4521156670344_241666d21cb6a509932a47697b35a9d3_7f390ac218ed427b8f4d73d735909755_master.jpg",
               55000,
               "Royal Canin",
               27));

            products.Add(new objects.product(16, "Dây da gắn tag inox khắc tên cho chó mèo - Pettag Mozzi",
               "Chưa có mô tả cho sản phẩm này",
               "https://product.hstatic.net/200000263355/product/z4499765243891_f26868d725349e3ee5933b1feb173ef0_0b60afd51da7471bbfaf65bf4ada1e82_master.jpg",
               125000,
               "Royal Canin",
               22));

            products.Add(new objects.product(17, "Dây da khắc tên đuôi dây cho chó mèo - Pettag Mozzi",
               "Chưa có mô tả cho sản phẩm này",
               "https://product.hstatic.net/200000263355/product/z4499763131586_91e6c600faa06f73c595e48c2e689ae3_092349d65a3a472686f94603ea08c2a2_master.jpg",
               65000,
               "Pettag Mozzi",
               9));

            products.Add(new objects.product(18, "Xương gặm sạch răng Orgo",
               "Xương gặm sạch răng Orgo 90gr giúp sạch răng, thơm miệng và bổ xung canxi do có có hàm lượng canxi cao, đáp ứng tốt cho mọi giống chó ở mọi độ tuổi khác nhau\r\n\r\n- Làm sạch răng, giúp hợp khẩu vị, giúp xương chắc khỏe, và bổ sung canxi.\r\n- Thành phần phomat chất lượng cao từ nguyên liệu thô, cùng với công thức sữa thơm ngon.\r\n- Giúp cho sự phát triển tốt của xương, răng, loại bỏ mảng bám cao răng, giúp răng trắng hơn Không khiến cún yêu của bạn gây mùi khó chịu.",
               "https://product.hstatic.net/200000263355/product/z5276830858853_d92fd7bcc639f012b1319c5cab2e8d20_a66893a0dde04eff8a103de2791691a8_master.jpg",
               35000,
               "Pettag Mozzi",
               10));

            products.Add(new objects.product(19, "Hoopet Nệm bông gối đầu cao cho chó mèo",
               "Nệm bông mềm tháo rời  cho chó mèo có chất liệu bông siêu mềm mịn giúp giữ ấm cơ thể, mát vào mùa hè và ấm áp vào mùa đông giúp bé thoải mái và thư giãn, có giấc ngủ ngon vào 4 mùa trong năm.\r\n\r\n- Nệm lót có thể tháo rời vỏ và ruột cùng khóa kéo tiện lợi",
               "https://product.hstatic.net/200000263355/product/z5042332863575_a7da0ecd6e966303a91f1d45879d7e6c_ea0b03306d76453ca92ad3d2552cb884_master.jpg",
               580000,
               "Khác",
               0));

            products.Add(new objects.product(20, "Pate Satiety Weight Management lon 410gr",
              "Pate Royal Canin Satiety Canine Wet hỗ trợ kiểm soát cân nặng cho chó thừa cân được nghiên cứu để hỗ trợ quá trình giảm cân an toàn ở những chú chó thừa cân và béo phì. Hiệu quả đã được chứng mình tại một thử nghiệm lâm sàng , 97% những chú chó tham gia giảm cân thành công trong 3 tháng và kiểm soát được hành vi xin ăn ở 83% số chó.",
              "https://product.hstatic.net/200000263355/product/z5079673924539_22ddfdef209bdb055c026b72a90cf57f_e0794f61d1f643e4a64d072a2715304f_master.jpg",
              80000,
              "Royal Canin",
              10));

            products.Add(new objects.product(21, "Đầm Caro Ren viền thêu Trái dâu",
              "Khách có thể inbox chọn màu mỗi mẫu, shop sẽ ưu tiên gửi khách đúng màu nếu kho còn, nếu kho hết shop xin phép giao màu ngẫu nhiên ạ \r\n❤ Khách có thể để lại sđt để shop tiện liên hệ nhé \r\n\r\nBạn inbox cho shop giống cún, mèo và cân nặng, tụi mình tư vấn size để bạn đặt hàng cho đúng ạ ",
              "https://product.hstatic.net/200000263355/product/z5005578103354_f3ee49ef4326fc8fa59899524620a7f7_68430a9267c24876a791f643a1db6e6a_master.jpg",
              195000,
              "Royal Canin",
              0));

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}