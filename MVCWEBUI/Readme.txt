M - Model
V - View
C - Controller

Model -  View ile Controller arasýnda veri transferi için kullanýlacak tipleri barýndýrýr.(DTO veya Entity lein barýndýrýldýðý bölge.)

View - clinet'a gönderilecek HTML'i hazýrlar...Ara yüzde gösterilecek methodtur.
NOT - HTML (Hyper Text Markup Lanugage) Yüksek Metin Ýþaretleyici dil kesinlikle html bir yazýlým dili deðildir. Düz yazýyý taraycýnýn anlayacaðý dile çeiren etiket dilidir.<etiket>HMTL'e döüntürülecek alan</etiket>

C - Controller yani gelen requestlarý karþýlayacak methodlarý barýndýrýr...bu metodlar bu istekleri yönlendirmesi gerekiyorsa yönlendirecek daha sonra da clienta yanýtný döndürecek...

Controller isimlendirmesi yaparken dikkat etmemiz gereken husus mutlaka Controllerýn isminin devamýnda Controller yazmasý gerekir...
Eðer herhangi bir yönlendirme yapýlmamýþsa clienttan gelen istek ilk olarka HomeController tarafýndan yakalanýr Index metoduna iletilir index metodu viev içerisinde görüntü dosyasý arar ve metotla ayný isimli cshtml uzantýlý görüntü dosyasýný alýr ve geriye döndürür. IActionResult geri dönüþ tipli view metodu bunu yapýyor.
view uzantýsý .cshtml - CSharp ve hmtl ortak uzantýsýdýr. hem Csharp hem html yazabileceðimizi ifade eder. Buna Razor Syntax denir.
@model ile belirtilen html sayfasýna gönderilecek olan veriyi temsil ederken, Model anahtar kelimesi ise erinin kendisini ifade eder.

birden fazla layout kullanabiliriz hatta 1 layout bir baþka layoutu kullanabilir.
DTO karþýlýðý ViewModel--













wwwroot - içerisinde resim, css, JavaScript gibi statik dosyalarý yerleþtiridðimiz klasör...
