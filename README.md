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


### Not

Bu ilk MD denemem olduğu için emojilerden link eklemeye kadar her şeyi denemek istedim. Bu README dosyasını şimdi oluşturduğum için önceki geliştirmelerde detaylı bilgi geçmedim.

Ancak bundan sonraki güncellemelerde ve getirilen değişikliklerde resim ve açıklamalarla beraber paylaşmayı düşünüyorum.

--------------------------------------
Engin Hoca'nın sözüyle sonlandıralım.
>Do not repeat yourself.
