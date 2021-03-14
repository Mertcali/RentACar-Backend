# :car:RentACarProject:car:

## :star:Başlarken

Bu projemizde bir araba kiralama uygulamasını baştan sona hazırlıyoruz. 

Bu proje Engin Demiroğ'un gönüllü C# anlattığı canlı derslerin sonrasında verdiği ödevler üzerinden geliştiriliyor. Öğrenip, gelişip, geliştiriyoruz.

## :star:Gereklilikler 

```
Autofac 6.1.0 (Business ve Core katmanında)
Autofac.Extensions.DependencyInjection 7.1.0 (Core ve WebAPI katmanında)
Autofac.Extras.DynamicProxy 6.0.0 (Business ve Core katmanında)
FluentValidation 9.5.1 (Business ve Core katmanında)
Microsoft.EntityFrameworkCore.SqlServer 3.1.11 (Core ve DataAccess katmanında)

Microsoft.AspNetCore.Http.Abstractions v2.2.0 (Business)
Microsoft.AspNetCore.Http.Features v5.0.3 (Business ve Core)

microsoft.AspNetCore.Authentication.JwtBearer 3.1.12  --> web api
Microsoft.IdentityModel.Tokens.Jwt 6.8.0              --> core 
Microsoft.IdentityModel.Tokens 6.8.0                  --> core
Autofac.Extensions.DependencyInjection 7.1.0          --> business
Microsoft.Extensions.DependencyInjection 5.0.1        --> business
```

## :star:Geliştirmeler
### 1.Entities,DataAccess,Business,Console katmanları oluşturuldu.

+Car classı oluşturulup, InMemory formatta GetById, GetAll, Add, Update, Delete operasyonları yazıldı.

### 2.Brand ve Color classları eklendi. Sql Serverda bir veritabanı oluşturuldu.(Cars,Brands,Colors tabloları eklendi.)

+Generic IEntityRepository yapısı yazıldı. EntityFramework altyapısı hazırlandı.

+Servislere GetCarsByBrandId , GetCarsByColorId  gibi operasyonlar eklendi.

+Sisteme araba eklenmesi için kurallar getirildi. (Araba ismi minimum 2 karakter olmalı, günlük fiyatı 0'dan büyük olmalı.)  

### 3.Core katmanı oluşturmaya başlanıldı.

+IEntity, IDto, IEntityRepository, EfEntityRepositoryBase oluşturuldu.

+Mevcut 3 class için CRUD(create,read,update,delete) operasyonları yazıldı.

+CarDetailDto oluşturulup 3 tablo joinlenerek bilgiler listelendi.

### 4.Core katmanında Results yapılandırması yapıldı. Kod iyileştirilmesi yapıldı.

+Users, Customers, Rentals classları ve tabloları oluşturuldu. Bütün operasyonlar bu sınıflar içinde yazıldı.

### 5.WebAPI katmanı kuruldu. Tüm servislerin API karşılığı yazıldı.

### 6.Autofac, FluentValidation, AOP destekleri eklendi.

+Bu katman oluşturulurken  [Engin Demiroğ'un github](https://github.com/engindemirog/NetCoreBackend/tree/master/Business) hesabından destek aldım.

+Bütün sınıfları eklemek için kurallar eklendi. Kurallar Postman'de test edildi. 
Eklemiş olduğum resimde Postman üzerinden kurallara uymayan bir post isteği gönderildi ve istek karşılanmadı.

![resim](https://user-images.githubusercontent.com/77545922/109542276-e98eba80-7ad5-11eb-90ab-bfda4065b5c1.PNG)

### 7.CarImages Tablosu oluşturuldu, FileHelper desteği eklendi.
+CarImages classı oluşturuldu. Service'i ve Manager'i yazıldı. DependencyResolvers'ta ataması çözüldü. ValidationRules'ta giriş kuralları yazıldı.
DataAccessLayer katmanı yazıldı. WebAPI'de CarImagesController oluşturuldu.

+Manager'da oluşturulan metot ile maksimum 5 resim sınırlandırılması getirildi.

+Eklenen resimlerin kendi belirlediğimiz Images dosyasında toplanması için FileHelper desteği eklendi.
Microsoft.AspNetCore.Http.Abstractions v2.2.0 (Business)
Microsoft.AspNetCore.Http.Features v5.0.3 (Business ve Core)
paketleri yüklendi.

Yapılan değişikliklerden sonra her arabaya birer resim eklendi.
![ödev13](https://user-images.githubusercontent.com/77545922/110364409-c70c1c80-8054-11eb-954d-61d5c70b9605.PNG)

Oluşan CarImages tablosu aşağıdaki gibidir.

![ödev13 1](https://user-images.githubusercontent.com/77545922/110364492-e73bdb80-8054-11eb-9839-252ee070b199.PNG)

5 resimden fazla yüklediğimizde gelen uyarı aşağıdaki gibidir.
![ödev13 2](https://user-images.githubusercontent.com/77545922/110364571-fcb10580-8054-11eb-962e-9285b0474814.PNG)

### 8. JWT Altyapısı kuruldu.

### Kurulan Paketler:

microsoft.AspNetCore.Authentication.JwtBearer 3.1.12  --> web api

Microsoft.IdentityModel.Tokens.Jwt 6.8.0              --> core 

Microsoft.IdentityModel.Tokens 6.8.0                  --> core

Autofac.Extensions.DependencyInjection 7.1.0          --> business

Microsoft.Extensions.DependencyInjection 5.0.1        --> business

### Özet

Entities Concrete User Class'ı Core katmanına taşındı.
User classında artık Password değil

        public byte[] PasswordSalt { get; set; }
        
        public byte[] PasswordHash { get; set; }
        
        public bool Status { get; set; }
        
şeklinde bi tanımlama olduğu için tablosu yeniden oluşturuldu.
**************************
+OperationClaims,UserOperationClaims tabloları oluşturuldu. Sınıfları oluşturuldu.
**************************
+WebAPI appsettings kısmında TokenOptions oluşturuldu.
**************************
+IUserService'e      

       List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        
eklendi. Manager'da düzenlemeleri yapıldı.
**************************
+Core-Utilities-Security
(JWT-Hashing-Encryption) 
klasörleri oluşturuldu.
HashingHelper oluşturuldu.
CreatePasswordHash ve VerifyPasswordHash metotları tanımlandı.
**************************
+Security klasörünün içerisine Encryption klasörlemesi yapıldı.
SecurityKeyHelper ve SigningCredentialHelper oluşturuldu.

*SigningCredential bizim securitykey ve algoritmamızı belirlediğimiz bir nesnedir.*

SecurityKey için microsoft.identitymodel.Tokens eklendi
**************************
+Core-Utilities-Security-JWT klasörü oluşturup Token alışverişi için gerekli 
sınıflar oluşturuldu.
**************************
+JwtHelper'da configuration tanımlaması yapıldı. Bunun için 
microsoft.extensions.configuration eklendi.
*(appsettingsten gelen token bilgilerini configuration yapısı ile okumamız sağlanıyor.)*

Constructorda yazdığımız

*_tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();*
  
ile appsettingsteki tüm TokenOptions'ı tek seferde alıyoruz.
**************************
+JwtHelper'da CreateToken için
microsoft.identitymodel.Tokens kullanıldı

JwtSecurityToken için System.identitymodel.tokens.jwt paketi kuruldu

JwtSecurityToken'da Expires'ı tarih şeklinde set edebilmek için constructorda
_accessTokenExpiration oluşturduk.
**************************

        var claims = new List<Claim>();
        claims.Add(new Claim("email", user.Email));

şeklinde hepsini teker teker yazmamak için claim nesnelerini extend ettik.
Core Katmanında Extensions oluşturuldu.
**************************
+JwtHelper işlemleri bittikten sonra Login,Register işlemleri yapacağımız katmana
yani Business katmanına dönüyor ve IAuthService oluşturuyoruz.

Business katmanındaki AuthManager'in login işlemi için 
ve başka yerlerde de kullanmak için Core katmanında HashingHelper oluşturuldu.

Manager işlemleri tamamlandı.
**************************
+Api kısmında startup düzenlendi.
Authentication için 
Microsoft.AspNetCore.Authentication.JwtBearer paketi eklendi.	
Authentication  -->giriş anahtarı
Authorization   -->yetki

### Testler ve Resimler
---> Register işlemi ve oluşturulan token.
![jwtregister](https://user-images.githubusercontent.com/77545922/111083790-3b94fe80-8520-11eb-855f-1a2441bd5894.PNG)

---> Yetkisi verilmeyen kullanıcının araba eklemeyi denemesi.
![jwtyetkinizreddedildi](https://user-images.githubusercontent.com/77545922/111083802-4bacde00-8520-11eb-9e73-a79059996345.PNG)

---> Yetki verildikten sonra kullanıcının araç eklemeyi denemesi.
![jwtyetkidensonra](https://user-images.githubusercontent.com/77545922/111083807-58313680-8520-11eb-893c-8ccde2755502.PNG)



### Not

Bu ilk MD denemem olduğu için emojilerden link eklemeye kadar her şeyi denemek istedim. Bu README dosyasını şimdi oluşturduğum için önceki geliştirmelerde detaylı bilgi geçmedim.

Ancak bundan sonraki güncellemelerde ve getirilen değişikliklerde resim ve açıklamalarla beraber paylaşmayı düşünüyorum.

--------------------------------------
Engin Hoca'nın sözüyle sonlandıralım.
>Do not repeat yourself.
