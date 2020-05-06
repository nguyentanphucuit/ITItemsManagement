<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LienKet.ascx.cs" Inherits="TaiNguyenDieuKhien_LienKet" %>
<table style="border: 1px solid rgb(238, 238, 238);" cellpadding="2" cellspacing="0"
    width="100%">
    <tbody>
        <tr>
            <td style="border: 1px solid rgb(173, 167, 154);" align="center" width="100%" height="32">
               <%-- <select size="1" name="link" onchange="Links()">
                    <option>Liên kết website</option>
                    <option value="http://www.vnexpress.net">Báo Vnexpress</option>
                    <option value="http://www.dantri.com.vn">Báo Dân trí</option>
                    <option value="http://www.cand.com.vn">Báo Công an nhân dân</option>
                    <option value="http://www.vir.com.vn">Báo Đầu tư</option>
                    <option value="http://www.gdtd.com.vn">Báo giáo dục thời đại</option>
                    <option value="http://www.hanoimoi.com.vn">Báo Hà Nội mới</option>
                </select>--%>
                <select class="links" name="choice" onchange="if(this.options[selectedIndex].value!=0){ window.open(this.options[selectedIndex].value)}">
	    <option value="0" selected="selected">Liên k&#7871;t Website</option>
									
									
                    
                    
                    	<option value="http://www.dangcongsan.vn">Báo &#272;i&#7879;n t&#7917; &#272;&#7843;ng CSVN</option>
                     
                    
                    	<option value="http://www.vietnam.gov.vn">Trang tin Chính ph&#7911;</option>
                     
                    
                    	<option value="http://www.na.gov.vn">Qu&#7889;c h&#7897;i</option>
                     
                    
                    	<option value="http://www.vtv.vn">&#272;ài THVN</option>
                     
                    
                    	<option value="http://www.vov.org.vn">&#272;ài TNVN</option>
                     
                    
                    	<option value="http://www.htv.org.vn">&#272;ài THHN</option>
                     
                    
                    	<option value="http://www.nhandan.org.vn">Báo Nhân Dân</option>
                     
                    
                    	<option value="http://www.qdnd.vn">Báo Q&#272;ND</option>
                     
                    
                    	<option value="http://www.hanoi.gov.vn">C&#7893;ng giao ti&#7871;p &#273;i&#7879;n t&#7917; HN</option>
                     
                    
                    	<option value="http://www.sggp.org.vn">Báo SGGP</option>
                     
                    
                    	<option value="http://www.ktdt.com.vn">Báo Kinh t&#7871; &amp; &#272;ô th&#7883;</option>
                     
                    
                    	<option value="http://www.baothainguyen.org.vn">Báo Thái Nguyên</option>
                     
                    
                    	<option value="http://www.baoyenbai.com.vn">Báo Yên Bái</option>
                     
                    
                    	<option value="http://www.baothanhhoa.com.vn">Báo Thanh Hóa</option>
                     
                    
                    	<option value="http://www.baobackan.org.vn">Báo B&#7855;c K&#7841;n</option>
                     
                    
                    	<option value="http://www.baobacgiang.com.vn">Báo B&#7855;c Giang</option>
                     
                    
                    	<option value="http://www.baohaiphong.com.vn">Báo H&#7843;i Phòng</option>
                     
                    
                    	<option value="http://www.baocantho.com.vn">Báo C&#7847;n Th&#417;</option>
                     
                    
                    	<option value="http://www.baodienbienphu.com.vn">Báo &#272;i&#7879;n Biên Ph&#7911;</option>
                     
                    
                    	<option value="http://www.baobinhdinh.com.vn">Báo Bình &#272;&#7883;nh</option>
                     
                    
                    	<option value="http://www.baokhanhhoa.com.vn">Báo Khánh Hòa</option>
                     
                    
                    	<option value="http://www.baodongnai.com.vn">Báo &#272;&#7891;ng Nai</option>
                     
                    
                    	<option value="http://www.baoquangninh.com.vn">Báo Qu&#7843;ng Ninh</option>
                     
                    
                    	<option value="http://www.vnn.vn">VietnamNet</option>
                     
                    
                    	<option value="http://www.vnmedia.com.vn">VnMedia</option>
                     
                    
                    	<option value="http://www.tienphongonline.com.vn">Báo Ti&#7873;n Phong</option>
                     
                    
                    	<option value="http://www.thanhnien.com.vn">Báo Thanh Niên</option>
                     
                    
                    	<option value="http://www.baohoabinh.com.vn/">Báo Hòa Bình</option>
                     
                    
                    	<option value="http://www.tuoitre.com.vn">Báo Tu&#7893;i Tr&#7867;</option>
                     
                    
                    	<option value="http://www.nld.com.vn">Báo NL&#272;</option>
                     
                    
                    	<option value="http://www.laodong.com.vn">Báo Lao &#272;&#7897;ng</option>
                     
                    
                    	<option value="http://www.antd.vn">Báo An ninh Th&#7911; &#273;ô</option>
                     
                    
                    	<option value="http://www.baonghean.vn">Báo Ngh&#7879; An</option>
                     
                    
                    	<option value="http://www.baolaocai.vn">Báo Lào Cai</option>
                   									
									
	</select>
            </td>
        </tr>
           <script>
	        function Links(){
	        var link = link.value;  
	        window.open(link);
	                        }
        </script>
    </tbody>
</table>