'ArtworksAgileworks'
http://wiki.corpautohome.com/pages/viewpage.action?pageId=29463642

http://10.168.0.49/wangyang/yuyue/index.html#p=����Ӯ��ҳ
'
/* task details */

�����˺ţ�
select * from clubMember where mName='�����������˶��ֳ�' 
select* from Dealers where DealerId=135920
select * from CarOffer where DealerId=135920 order by InsertTime desc


-----------------------
-- ��������

begin tran 
update CarOffer set dealerid=82120,OfferStatus=0 where OfferId in (
200,
201,
202,
203,
204);
/*
update CarOffer set InfoId=629678 where OfferId=200
update CarOffer set InfoId=216790 where OfferId=201
update CarOffer set InfoId=282812 where OfferId=202
update CarOffer set InfoId=656868 where OfferId=203
update CarOffer set InfoId=603039 where OfferId=204
*/
-- commit 

���Ȩ�ޣ�
begin tran 
insert into ClubMemberRole (memberId,roleId) values (5131097,1)
insert into ClubMemberRole (memberId,roleId) values (5131097,5)
insert into ClubMemberRole (memberId,roleId) values (5131097,10)
insert into ClubMemberRole (memberId,roleId) values (5131097,15)

1.DealerIndex_V2.aspx.cs;DealerIndex_V1.aspx.cs ����ѯ�۹����޸�Ϊ��ԤԼѯ�۹���
2.ѯ��ԤԼ����-δ������  SellTrail/QuotedPriceList.aspx
	1)���������ʾ����ͼ����������Դ�������͡�ѯ�ۡ�����ԤԼ"
	function showlayer1(mobile, layer) �޸�

3.��������Ҫ��ѯ�����ͣ�ԤԼʱ�����������

declare @dealerid int 
declare @mobile varchar(20)
declare @status int 

set @status=0
set @mobile=13121976420	
set @dealerid=135920

select c.InfoId,c.carname,v.Price,v.Displacement,v.RegisteDate,v.Mileage,v.Gearbox,v.IsPublic,v.IsSelled,v.IsOverTime 
,c.appointmenttime,c.leavemessage,c.OfferType

                    ,(select top 1 sourcePic
					
					
					 from UsedCarPic with(nolock) where 
					c.InfoId=UsedCarPic.infoId and UsedCarPic.picType=10) sourcePic from  CarOffer c with(nolock) 
                    join (

                    select Price,Displacement,RegisteDate,Mileage,Gearbox,InfoId,IsPublic,IsSelled,IsOverTime
					 from QuotePrice with(nolock) where CompanyId=@dealerid and IsOutSite=0
                    union 
                    select Price,Displacement,RegisteDate,Mileage,Gearbox,InfoId,IsPublic,IsSelled,IsOverTime 
					from QuoteCarSelled  with(nolock) where CompanyId=@dealerid and IsOutSite=0 )v
                    on v.InfoId=c.InfoId

                    where dealerid=@dealerid and OfferStatus=@status  and Mobile=@mobile 
                    order by c.InsertTime desc --/WebSite.Dealer.Admin/App_Code/DAL/SellTrail/CarOffer.cs


4.�Ϻ�������֤���ֳ����У�Ǭ�������ݣ�	��¼�˺ţ�Ǭ����ֳ�
��˾��ַ���Ϻ���¬������ɽ��һ·727�� 

��¼�ɲ�������


'
