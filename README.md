<div align="center">
  <h1>🌑 PROJECT HUNTER</h1>
  <h3>Audio-Driven Predictive AI & Behavior Tree Simulation</h3>
  <br>
  <i>"Bir oyunun gerilimini yaratan şey düşmanın ne kadar güçlü olduğu değil; <br> nefesinizi ne kadar iyi dinlediği ve bir sonraki adımınızı ne kadar iyi tahmin ettiğidir."</i>
</div>

<br>

**Project Hunter**, oyuncunun psikolojisiyle oynamak üzere tasarlanmış otonom bir hayatta kalma-gerilim yapay zekasıdır. Unity oyun motoru üzerinde tamamen sıfırdan inşa edilen bu sistem; sıradan ve hantal `if/else` yığınlarını reddeder. Bunun yerine, modern oyun endüstrisinin standardı olan **Modüler Davranış Ağacı (Behavior Tree)** mimarisini, matematiğin kusursuzluğu ve karanlık, dinamik bir ses tasarımıyla (Audio-Driven) tek bir zihinde birleştirir.

Bu sistem sadece bir düşman kodu değildir; oyuncunun ayak seslerini dinleyen, zemin akustiğini analiz eden, görsel engelleri fark eden ve vektörel hesaplamalarla saniyeler sonrasını öngörerek avını köşeye sıkıştıran dijital bir avcıdır.

---

## 🛠️ Kullanılan Teknolojiler & Mühendislik Araçları

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/unity/unity-original.svg" title="Unity 3D" alt="Unity" width="50" height="50"/>&nbsp;&nbsp;
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" title="C#" alt="C#" width="50" height="50"/>&nbsp;&nbsp;
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg" title="VS Code" alt="VS Code" width="50" height="50"/>&nbsp;&nbsp;
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/git/git-original.svg" title="Git" alt="Git" width="50" height="50"/>
</div>

* **Oyun Motoru & Çevre (Engine):** Unity 6000.x (3D Core) — Gelişmiş Gizmos/Handles API (Taktiksel HUD tasarımı), Fizik Tabanlı Çevre Algılama (`Physics.Raycast`) ve Dinamik Bileşen Yönetimi.
* **Programlama Dili:** C# (.NET) — Katı Nesne Yönelimli Programlama (OOP) prensipleri, Veri Odaklı Tasarım (`ScriptableObjects`) ve düşük dışa bağımlılık (Decoupled Design).
* **Sistem Mimarisi:** Özel Davranış Ağacı (Custom Behavior Tree) — Hiyerarşik durum yönetimine (Sequence, Selector, Leaf Nodes) sahip modüler yapay zeka beyni.
* **Matematik & Algoritmalar:** Graf Teorisi (Graph Theory) ile optimize edilmiş A* (A-Star) Pathfinding; Vektör Kalkülüsü (Vector Calculus) ve Kinetik Akıcılık (`Quaternion.Slerp`).
* **İşitsel Dinamikler (Audio Engine):** Unity AudioSource API — Uzamsal ses (Spatial Blend) matematiği ve mesafeye dayalı Lerp interpolasyonu ile dinamik gerilim motoru.

---

## ⚙️ Sistemin Sunduğu Derin Mekanikler

### 1. Kestirimci (Predictive) Hedefleme ve İleri Vektör Matematiği
Standart yapay zeka sistemleri hedefin geçmişini takip ederken, Project Hunter geleceği hesaplar. Avcının zihni, hedefin anlık hız vektörünü ($v = \frac{\Delta x}{\Delta t}$) ölçerek zaman/mesafe denklemleri kurar. A* algoritması, avın o anki konumuna değil; kusursuz bir matematikle hesaplanmış **kesişim (pusu) noktasına** çizilir. 

### 2. Bilişsel Hafıza (Object Permanence) ve Gerçek Görüş Açısı
Sistem, basit 0 ve 1 mantığıyla çalışmaz. Avcının görüş açısı (`Physics.Raycast` destekli) fiziksel duvarların arkasını göremez. Ancak av, görüş açısından veya duyma menzilinden çıksa bile sistem hemen hafızasını sıfırlamaz. **3 saniyelik Bilişsel Hafıza Tamponu (Memory Buffer)** sayesinde avcı, avın son bilinen rotasına doğru agresif bir şekilde depar atmaya devam eder. Bu, "Durum Atlama" (State Jumping) hatalarını engelleyen organik bir avlanma içgüdüsüdür.

### 3. Kinetik Akıcılık (Kinematic Smoothing) ve Optimizasyon
A* algoritmasının işlemciyi (CPU) boğmasını ve "Pathfinding Paralysis" (olduğu yere çivilenme) hatalarını engellemek için rota hesaplamaları her frame'de değil, **0.15 saniyelik aralıklarla** yapılır. Avcı köşeleri dönerken robotik bir şekilde titremez; genişletilmiş hedef kabul yarıçapı ve `Quaternion.Slerp` matematiği sayesinde yörüngesinde pürüzsüz kavisler çizer.

### 4. İşitsel Gerilim Yönetimi (Audio-Driven State Machine)
Oyunun ses miksajı doğrudan yapay zekanın sinir sistemine (Behavior Tree) ve mesafesine bağlıdır. Avcı devriye modundayken sadece karakterin sinsi fısıltıları yankılanır. Hedef algılandığı an, fısıltılar yerini agresif kovalama ritimlerine bırakır. Avcı hedefe yaklaştıkça, aradaki mesafe vektörüne oranla sesin tınısı (Pitch) dinamik olarak `Mathf.Lerp` ile yükseltilir ve oyuncunun üzerindeki psikolojik baskı maksimize edilir.

---

## 👁️ Siber-Optik Test Ekranı (Tactical HUD)

Klasik `Debug.Log` konsol mesajları ve karmaşık tel örgü çizgileri (Wireframes) yerine, sistem Unity'nin `Handles` API'sini kullanan estetik bir Taktiksel Radar sunar. Play modundayken yapay zekanın iç dünyasını anlık olarak izleyebilirsiniz:

* **Altın Görüş Konisi & Kan Kırmızısı Radar:** Görsel ve işitsel algı alanları yarı saydam geometrik şekillerle izole edilir.
* **Kestirimci Vektör (Predictive Line):** Hedefin hızına göre avcının pusu kuracağı $x,z$ koordinatını gerçek zamanlı gösteren kesik (dashed) siyan çizgiler.
* **Yüzen Zihin Monitörü (Floating HUD):** Avcının başının üzerinde beliren `[ AI CORE ]` paneli, sistemin anlık kararını (`PATROLLING`, `HUNTING`, `TERMINATED`) ekrana yansıtır.

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
  
* Deney 3 (Deterministik Ölüm): Avcının ölümcül çapı (Catch Radius) içine bilerek girin. Sistemin bitirici vuruş sesini çaldığı an, bellek sızıntılarını önlemek adına simülasyonu motor seviyesinde (Time.timeScale = 0) nasıl dondurduğunu (TERMINATED) gözlemleyin.

---

## 🎨 Kendi Oyununuza Entegrasyon (Data-Driven Architecture)

Bu sistem, herhangi bir projeye "Tak-Çalıştır" (Plug-and-Play) mantığıyla entegre edilecek şekilde esnek ve modüler yazılmıştır. `ScriptableObjects` kullanılarak oluşturulan **Hunter Profile** mimarisi sayesinde, tek satır kod değiştirmeden yüzlerce farklı düşman tipi (Hızlı, sağır, sinsi, agresif vb.) yaratabilirsiniz.

### 1. Zihin Matrisini Kurmak (Grid & Environment)
* Sahnenize boş bir obje (Empty GameObject) açın ve `GridManager.cs` scriptini ekleyin. Haritanızın boyutlarına göre Grid sınırlarını belirleyin.
* Haritanızdaki geçilemez engellere (Duvarlar, kayalar vb.) Inspector üzerinden yeni bir Layer oluşturup `Obstacle` katmanını atayın. `GridManager` bu engelleri otomatik olarak tarayacaktır.

### 2. Avı İşaretlemek (Target Tracking)
* Kendi oyuncu (Player) karakterinizi sahneye alın.
* Üzerine `TargetTracker.cs` (ve klavye ile test etmek isterseniz `PreyController.cs`) scriptini ekleyin. Bu yapı, oyuncunun anlık hız vektörünü avcının kestirimci (predictive) zihnine yayınlayacaktır.

### 3. Avcıyı Yaratmak (AI Instantiation)
* Kendi 3D canavar veya katil modelinize `HunterAI.cs` scriptini ekleyin. *(Not: Script, defansif programlama gereği ihtiyaç duyduğu AudioSource ve LineRenderer bileşenlerini kendi kendine yaratacaktır).*
* `HunterAI` scriptinin içindeki **Target** yuvasına oyuncunuzu, **Target Tracker** yuvasına ise oyuncunuzun üzerindeki takip scriptini sürükleyin.

### 4. Zihni Şekillendirmek (ScriptableObject Profiles)
* Unity proje (Project) pencerenizde sağ tıklayın ve `Create -> AI -> Hunter Profile` diyerek yeni bir veri şablonu oluşturun.
* Avcının hızını, görüş açısını (FOV Angle), duyma menzilini ve işitsel dosyalarını (Patrol/Chase/Catch sesleri) bu profilden ayarlayın.
* Oluşturduğunuz bu profili, avcının üzerindeki `HunterAI` scriptinin **Profile** yuvasına sürükleyin. 

Artık avcınız; otonom olarak devriye gezmeye, engellerin etrafından dolanmaya ve avını avlamaya tamamen hazır.

---

## 📫 İletişim & Ağ (Network)

Bu karanlık simülasyonun arkasındaki zihniyet, yazılım mühendisliği ile ses/atmosfer tasarımını birleştirmektir. Sektördeki profesyonellerle tanışmaktan, geri bildirim almaktan ve yeni ufuklara yelken açmaktan her zaman onur duyarım. Benimle aşağıdaki kanallardan iletişime geçebilirsiniz:

* **LinkedIn:** www.linkedin.com/in/beyza-yazıcı-400183332
* **E-Posta:** beyza04yazici2005@gmail.com
* **GitHub:** [github.com/DioBey7](https://github.com/DioBey7)

---

## 📄 Lisans (MIT License)

Bu proje **MIT Lisansı** ile korunmaktadır ve açık kaynaklıdır. 
Kısaca; bu repodaki tüm kodları, mimariyi ve sistem tasarımını kopyalamakta, değiştirmekte ve kendi kişisel veya ticari oyun projelerinizde kullanmakta tamamen özgürsünüz. Tek şart, orijinal geliştiriciye (Beyza Yazıcı) atıfta bulunulmasıdır. Daha fazla hukuki detay için reponun kök dizinindeki `LICENSE` dosyasına göz atabilirsiniz.
