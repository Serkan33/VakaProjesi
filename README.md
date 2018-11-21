# VakaProjesi
Vaka çalışması C# dili ile geliştirilmiş bir oop uygulamasıdır. Uygulamada iki adet robotik gezgin bulunmakta ve yüzeyden fotoğraf almaktadır.
- Robotik gezginin yönünü değiştirmek için **L,R** kombinasyonlarını kullanabilirsiniz.
- Robotik gezginin hareket ettirmek için **M** kombinasyonunu kullanabilirsiniz.
- İlk robot hareketini tamamladıktan sonra ( başladığı noktaya geri döndüğünü varsayarsak ) ikinci robot harekete geçebilir.
## Projeyi Çalıştırmak 
- Projeyi çalıştırmak için Windows işletim sisteminizde **NET 4.5 Framework** olmalı
- Projeyi klonladıktan yada indirdikten sonra `CaseProject > bin > CaseProject.exe` yolunu takip ederek çalıştırabilirsiniz

## Inputs
- İlk açılan ekranda karşınıza iki kutucuk çıkacaktır.
- İlk kutucuk uzay alanınızın boyutu için gireceğiniz alandır. İlk değer `Genişlik` ikinci değer `Yükseklik` olarak kabul edilecektir. Bu alana sadece **_pozitif rakamlar_** girebilirsiniz. **Değerler arasında bir boşluk olmalıdır** Örnek : `800 500`
- İkinci kutucuk gezegenin bulunacağı ilk konumu ayarlar. Aynı şekilde  **_pozitif rakamlar_** ve **_değerler arasında bir boşluk olmalıdır_**. 
- Gezegen yüzeyi açıldıktan sonra en altta bulunan input robotu hareket ettirmek için kullanılacak alandır.