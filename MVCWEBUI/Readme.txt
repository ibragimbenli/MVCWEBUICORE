M - Model
V - View
C - Controller

Model -  View ile Controller aras�nda veri transferi i�in kullan�lacak tipleri bar�nd�r�r.(DTO veya Entity lein bar�nd�r�ld��� b�lge.)

View - clinet'a g�nderilecek HTML'i haz�rlar...Ara y�zde g�sterilecek methodtur.
NOT - HTML (Hyper Text Markup Lanugage) Y�ksek Metin ��aretleyici dil kesinlikle html bir yaz�l�m dili de�ildir. D�z yaz�y� tarayc�n�n anlayaca�� dile �eiren etiket dilidir.<etiket>HMTL'e d��nt�r�lecek alan</etiket>

C - Controller yani gelen requestlar� kar��layacak methodlar� bar�nd�r�r...bu metodlar bu istekleri y�nlendirmesi gerekiyorsa y�nlendirecek daha sonra da clienta yan�tn� d�nd�recek...

Controller isimlendirmesi yaparken dikkat etmemiz gereken husus mutlaka Controller�n isminin devam�nda Controller yazmas� gerekir...
E�er herhangi bir y�nlendirme yap�lmam��sa clienttan gelen istek ilk olarka HomeController taraf�ndan yakalan�r Index metoduna iletilir index metodu viev i�erisinde g�r�nt� dosyas� arar ve metotla ayn� isimli cshtml uzant�l� g�r�nt� dosyas�n� al�r ve geriye d�nd�r�r. IActionResult geri d�n�� tipli view metodu bunu yap�yor.
view uzant�s� .cshtml - CSharp ve hmtl ortak uzant�s�d�r. hem Csharp hem html yazabilece�imizi ifade eder. Buna Razor Syntax denir.
@model ile belirtilen html sayfas�na g�nderilecek olan veriyi temsil ederken, Model anahtar kelimesi ise erinin kendisini ifade eder.

birden fazla layout kullanabiliriz hatta 1 layout bir ba�ka layoutu kullanabilir.
DTO kar��l��� ViewModel--













wwwroot - i�erisinde resim, css, JavaScript gibi statik dosyalar� yerle�tirid�imiz klas�r...
