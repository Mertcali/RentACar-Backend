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






### Not

Bu ilk MD denemem olduğu için emojilerden link eklemeye kadar her şeyi denemek istedim. Bu README dosyasını şimdi oluşturduğum için önceki geliştirmelerde detaylı bilgi geçmedim.

Ancak bundan sonraki güncellemelerde ve getirilen değişikliklerde resim ve açıklamalarla beraber paylaşmayı düşünüyorum.

--------------------------------------
Engin Hoca'nın sözüyle sonlandıralım.
>Do not repeat yourself.
