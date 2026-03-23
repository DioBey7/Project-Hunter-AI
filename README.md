<div align="center">
  <h1>🌑 PROJECT HUNTER</h1>
  <h3>Audio-Driven Predictive AI & Behavior Tree Simulation</h3>
  <br>
  <i>"Bir oyunun gerilimini yaratan şey düşmanın ne kadar güçlü olduğu değil; <br> nefesinizi ne kadar iyi dinlediği ve bir sonraki adımınızı ne kadar iyi tahmin ettiğidir."</i>
</div>

<br>

**Project Hunter**, oyuncunun psikolojisiyle oynamak üzere tasarlanmış otonom bir hayatta kalma-gerilim yapay zekasıdır. Unity oyun motoru üzerinde tamamen sıfırdan inşa edilen bu sistem; sıradan ve hantal `if/else` yığınlarını reddeder. Bunun yerine, modern oyun endüstrisinin standardı olan **Modüler Davranış Ağacı (Behavior Tree)** mimarisini, matematiğin kusursuzluğu ve karanlık, dinamik bir ses tasarımıyla (Audio-Driven) tek bir zihinde birleştirir.

Bu sistem sadece bir düşman kodu değildir; oyuncunun ayak seslerini dinleyen, zemin akustiğini analiz eden ve vektörel hesaplamalarla saniyeler sonrasını öngörerek avını köşeye sıkıştıran dijital bir avcıdır.

---

## 🛠️ Kullanılan Teknolojiler & Mühendislik Araçları

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/unity/unity-original.svg" title="Unity 3D" alt="Unity" width="50" height="50"/>&nbsp;&nbsp;
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" title="C#" alt="C#" width="50" height="50"/>&nbsp;&nbsp;
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg" title="VS Code" alt="VS Code" width="50" height="50"/>&nbsp;&nbsp;
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/git/git-original.svg" title="Git" alt="Git" width="50" height="50"/>
</div>

* **Oyun Motoru & Çevre (Engine):** Unity 6000.x (3D Core) — Gelişmiş Gizmos API (Özel Editör Araçları tasarımı), Fizik Tabanlı Çevre Algılama (`Physics.CheckSphere`) ve Dinamik Bileşen Yönetimi (`RequireComponent`).
* **Programlama Dili:** C# (.NET) — Katı Nesne Yönelimli Programlama (OOP) prensipleri, "Clean Code" felsefesi ve düşük dışa bağımlılık (Decoupled Design).
* **Sistem Mimarisi:** Özel Davranış Ağacı (Custom Behavior Tree) — Karmaşık if/else yığınlarını (spagetti kod) engelleyen, hiyerarşik durum yönetimine (Sequence, Selector, Leaf Nodes) sahip modüler yapay zeka beyni.
* **Matematik & Algoritmalar:** Ayrık Matematik (Discrete Math) ve Graf Teorisi (Graph Theory) ile sıfırdan oluşturulmuş A* (A-Star) Pathfinding; Vektör Kalkülüsü (Vector Calculus) ile entegre edilmiş Kestirimci (Predictive) Pusu Matematiği.
* **İşitsel Dinamikler (Audio Engine):** Unity AudioSource API — Uzamsal ses (Spatial Blend) matematiği ve zihinsel duruma bağlı (State-Driven) anlık tetiklenen dinamik gerilim motoru.

---

## ⚙️ Sistemin Sunduğu Derin Mekanikler

### 1. Kestirimci (Predictive) Hedefleme ve İleri Vektör Matematiği
Standart yapay zeka sistemleri hedefin geçmişini takip ederken, Project Hunter geleceği hesaplar. Avcının zihni, hedefin anlık hız vektörünü ($v = \frac{\Delta x}{\Delta t}$) ölçerek zaman/mesafe denklemleri kurar. A* (A-Star) algoritması, avın o anki konumuna değil; kusursuz bir matematikle hesaplanmış **kesişim (pusu) noktasına** çizilir. Bu, oyuncuya sadece "izlendiği" değil, zeki bir varlık tarafından acımasızca "avlandığı" hissini veren analitik mühendisliktir.

### 2. Dinamik Akustik Algı ve Zemin Maliyeti (Terrain Cost)
Haritadaki her zemin karanlıkta farklı yankılanır. Sistem, oyuncunun bastığı zeminin materyaline (`terrainCost`) göre avcının işitsel algı çemberini (Hearing Radius) anlık olarak modifiye eder. Sessiz bir halıda güvende olabilirsiniz; ancak paslı bir metal ızgaraya bastığınız an, duvarların arkasındaki o zihin yankıyı sezer ve rotasını anında üzerinize çevirir.

### 3. İşitsel Gerilim Yönetimi (Audio-Driven State Machine)
Oyunun ses miksajı doğrudan yapay zekanın sinir sistemine (Behavior Tree) bağlıdır. Avcı devriye (Patrol) modundayken ortamda sadece karakterin sinsi fısıltıları yankılanır. Hedef algılandığı an (Chase), fısıltılar bıçak gibi kesilir ve yerini oyuncunun kalp atışını hızlandıracak agresif rock/metal ritimlerine bırakır. Bu sistem, kodlama ile ses tasarımının tek bir potada eritilmiş halidir.

### 4. Defansif Programlama ve Hata Önleyici (Foolproof) Mimari
Sektör standartlarındaki kalabalık ekip çalışmaları (Level Designer ve Artist'lerin varlığı) göz önüne alınarak geliştirilmiştir. `[RequireComponent]` hiyerarşisi ve Null-Check güvenlik ağları sayesinde; sahne tasarımcıları objeye `LineRenderer` veya `AudioSource` eklemeyi unutsalar dahi, kod kendi bileşenlerini runtime'da (oyun oynanırken) otomatik olarak inşa eder. **Sıfır çökme (Crash-Free), maksimum stabilite.**

---

## 🚀 Hızlı Başlangıç & Kurulum Rehberi

Projenin arkasındaki ağır matematiği ve işitsel gerilimi kendi bilgisayarınızda test etmek için aşağıdaki adımları izleyin:

### 📋 Ön Gereksinimler (Prerequisites)
* **Unity Hub & Motoru:** Unity 6000.x veya daha güncel bir sürüm (3D Core).
* **Git:** Projeyi klonlamak için sisteminizde Git kurulu olmalıdır.

### 🛠️ Kurulum Adımları
1. **Zihni Klonlayın:** Terminalinizi açın ve repoyu bilgisayarınıza çekin:
   ```bash
   git clone [https://github.com/DioBey7/Project-Hunter-AI.git](https://github.com/DioBey7/Project-Hunter-AI.git)

2. **Motoru Başlatın:** Unity Hub'ı açın, Add (Ekle) butonuna tıklayarak klonladığınız proje klasörünü seçin ve projeyi başlatın. Scriptlerin derlenmesi (compilation) için birkaç saniye bekleyin.
3. **Sahneyi Yükleyin:** Project panelinden Assets/Scenes klasörüne gidin ve Main Scene (Ana Sahne) dosyasını çift tıklayarak açın.Sahneyi Yükleyin: Project panelinden Assets/Scenes klasörüne gidin ve Main Scene (Ana Sahne) dosyasını çift tıklayarak açın.

### 🔬 Test ve Gözlem (Simülasyonu Okumak)
Oyun motorunun üst kısmındaki Play tuşuna basın ve Sahne (Scene) penceresindeki Gizmos butonunun <ins>açık</ins> olduğundan emin olun. Sistemin gücünü görmek için şu iki deneyi gerçekleştirin:

* Deney 1 (İşitsel Gerilim): Hedef objeyi (Av) alın ve haritanın sessiz bölgesinden, gürültülü bölgesine (örneğin metal zemin kabul ettiğimiz alana) sürükleyin. Avcının etrafındaki kırmızı çemberin (Duyma Menzili) aniden nasıl devasa bir boyuta ulaştığını ve karakterin sinsi fısıltılarının yerini nasıl agresif bir kovalama müziğine bıraktığını gözlemleyin.
* Deney 2 (Kestirimci Matematik): Hedef objeyi sahnede hızlıca hareket ettirin. Avcının çizdiği rotanın (siyah/kırmızı lazer) sizin arkanızdan gelmediğini; aksine, hız vektörünüzü hesaplayarak doğrudan önünüzdeki mavi pusu noktasına (Interception Point) nasıl kilitlendiğini izleyin.

---

## 🎨 Kendi Oyununuza Entegrasyon (Modülerlik ve Clean Code)

Bu yapay zeka sistemi, herhangi bir projeye "Tak-Çalıştır" (Plug-and-Play) mantığıyla kolayca entegre edilecek şekilde esnek ve dışa bağımlılığı en aza indirilerek (Clean Code) yazılmıştır. Kendi karanlık atmosferinizi yaratmak için şu adımları izlemeniz yeterlidir:

### 1. Dünyayı İnşa Etmek (Zihin Matrisi ve Level Design)
Sistemin çalışması için Unity'nin kendi NavMesh'ine ihtiyacınız yoktur; sistem kendi ayrık matematik ağını kurar.
* Sahnenize boş bir obje açın ve `GridManager` scriptini ekleyin. Haritanızın büyüklüğüne göre `Grid World Size` değerini (örn: 100x100) ayarlayın.
* Sahnenizdeki duvarları, kayaları veya içinden geçilemez nesneleri seçin. Inspector'un sağ üstünden yeni bir **Layer** oluşturup adını `Unwalkable` yapın ve bu nesnelere atayın.
* `GridManager` scriptindeki `Unwalkable Mask` seçeneğinden bu katmanı seçin. Oyun başladığında matris otomatik olarak bu engelleri okuyup kırmızıya boyayacaktır.

### 2. Avı İşaretlemek (Hedef Takibi)
Avcının hedefini öngörebilmesi için hedefin ivmesini okuması gerekir.
* Kendi oyuncu (Player) karakterinizi sahneye alın.
* Üzerine `TargetTracker.cs` scriptini ekleyin. Bu, oyuncunun hız vektörünü anlık olarak uzaya yayınlayacaktır.

### 3. Bedeni Giydirmek ve Ruhu Uyandırmak (AI Kurulumu)
* Siyah küre (placeholder) yerine kendi 3D canavar veya katil modelinizi sahneye sürükleyin.
* Modelinize `HunterAI.cs` scriptini ekleyin (Script, ihtiyaç duyduğu `AudioSource` ve `LineRenderer` bileşenlerini kendi kendine yaratacaktır).
* Scriptin içindeki **Target** yuvasına oyuncunuzu, **Target Tracker** yuvasına ise oyuncunuzun üzerindeki takip scriptini sürükleyin.

### 4. Devriye Noktaları ve İşitsel Atmosfer (Waypoints & Audio)
* Sahnenizde boş objeler (Empty GameObjects) yaratarak avcının nöbet tutacağı kilit noktaları belirleyin ve bunları `HunterAI` içindeki **Waypoints** dizisine (array) sürükleyin.
* `Assets/Audio` klasörünüze kendi hazırladığınız ses dosyalarını (`.mp3` / `.wav`) atın. `Patrol Sound` (sakin nefes/fısıltı) ve `Chase Sound` (agresif kovalamaca müziği) yuvalarına bu dosyaları yerleştirin.
* ---

## 📫 İletişim & Ağ (Network)

Bu karanlık simülasyonun arkasındaki zihniyet, yazılım mühendisliği ile ses/atmosfer tasarımını birleştirmektir. Sektördeki profesyonellerle tanışmaktan, geri bildirim almaktan ve yeni ufuklara yelken açmaktan her zaman onur duyarım. Benimle aşağıdaki kanallardan iletişime geçebilirsiniz:

* **LinkedIn:** www.linkedin.com/in/beyza-yazıcı-400183332
* **E-Posta:** iletisim@eposta-adresiniz.com
* **GitHub:** [github.com/DioBey7](https://github.com/DioBey7)

---

## 📄 Lisans (MIT License)

Bu proje **MIT Lisansı** ile korunmaktadır ve açık kaynaklıdır. 
Kısaca; bu repodaki tüm kodları, mimariyi ve sistem tasarımını kopyalamakta, değiştirmekte ve kendi kişisel veya ticari oyun projelerinizde kullanmakta tamamen özgürsünüz. Tek şart, orijinal geliştiriciye (Beyza Yazıcı) atıfta bulunulmasıdır. Daha fazla hukuki detay için reponun kök dizinindeki `LICENSE` dosyasına göz atabilirsiniz.
