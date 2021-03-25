##Containerize:
 - Dockerı multi stage olarak olusturdum.
 - Docker fileda 80 ve 443 portlarını actım.
 - Pipeline olmadan localde projeyi çalıştırmak istediğimizde bu komut ile build ediyoruz: docker build -t cagil -f sentugcagil/Dockerfile . 
 - Çalıştırmak istediğimizde docker run -d -o 3000:80 cagil komutunu kullanabiliyoruz.
 
##Webhook:
 - https://webhook.site/#!/58281ffb-2f8d-402f-bc12-986cf7aa7cf9/40441724-0e00-4639-88d0-b2bbb40a35c8/1 
 - Yukarıdaki url üzerinden postlara ulaşabilirsiniz.
 - Json formatında bir script gönderiyorum.
 - Postman üzerinden post atabiliyorum.
 
##Diagram:
![Image of Diagram](https://user-images.githubusercontent.com/79908791/112396449-38182900-8d11-11eb-8500-f12dae5a6819.png =600x800) 
