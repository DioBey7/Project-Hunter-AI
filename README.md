<div align="center">
  <h1>PROJECT HUNTER</h1>
  <h3>Audio-Driven Predictive AI & Behavior Tree Simulation</h3>
  <br>
  <i>"Bir oyunun gerilimini yaratan şey düşmanın ne kadar güçlü olduğu değil; <br> nefesinizi ne kadar iyi dinlediği ve bir sonraki adımınızı ne kadar iyi tahmin ettiğidir."</i>
  <br>
  <i>"What creates a game's tension is not how powerful the enemy is; <br> but how well it listens to your breath and predicts your next move."</i>
</div>

<br>

---

## 🇹🇷 Türkçe Versiyon | 🇬🇧 English Version

---

### 🇹🇷 Türkçe

**Project Hunter**, oyuncunun psikolojisiyle oynamak üzere tasarlanmış otonom bir hayatta kalma-gerilim yapay zekasıdır. Unity oyun motoru üzerinde tamamen sıfırdan inşa edilen bu sistem, bilgisayar vizyonu (Computer Vision), vektör matematiği (Vector Calculus) ve davranış ağacı (Behavior Tree) mimarisinin dehşetengiz bir sentezi.

Bu sistem sadece bir düşman kodu değildir; oyuncunun ayak seslerini dinleyen, zemin akustiğini analiz eden, görsel engelleri fark eden ve vektörel hesaplamalarla saniyeler sonrasını öngören **duyarlı, prediktif ve ölümcül** bir yapay zekadır.

---

### 🇬🇧 English

**Project Hunter** is an autonomous survival-horror artificial intelligence designed to manipulate the player's psychology. Built from scratch on the Unity game engine, this system is a terrifying synthesis of computer vision, vector calculus, and behavior tree architecture.

This is not just enemy code; it's a **sentient, predictive, and lethal** AI that listens to the player's footsteps, analyzes floor acoustics, perceives visual obstacles, and predicts the future seconds ahead through vector mathematics.

---

## 🛠️ Kullanılan Teknolojiler & Mühendislik Araçları | Technologies & Engineering Tools

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/unity/unity-original.svg" title="Unity 3D" alt="Unity" width="50" height="50"/>&nbsp;&nbsp;
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" title="C#" alt="C#" width="50" height="50"/>&nbsp;&nbsp;
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg" title="VS Code" alt="VS Code" width="50" height="50"/>&nbsp;&nbsp;
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/git/git-original.svg" title="Git" alt="Git" width="50" height="50"/>
</div>

| Kategori | TR | EN |
|:---|:---|:---|
| **Oyun Motoru** | Unity 6000.x (3D Core) — Gelişmiş Gizmos/Handles API, Fizik Tabanlı Çevre Algılama | Unity 6000.x (3D Core) — Advanced Gizmos/Handles API, Physics-Based Environment Sensing |
| **Programlama Dili** | C# (.NET) — Katı OOP, ScriptableObjects, Decoupled Design | C# (.NET) — Strict OOP, ScriptableObjects, Decoupled Architecture |
| **Sistem Mimarisi** | Özel Davranış Ağacı (Custom Behavior Tree) — Hiyerarşik durum yönetimi | Custom Behavior Tree — Hierarchical State Management (Sequence, Selector, Leaf Nodes) |
| **Matematik & Algoritmalar** | A* Pathfinding, Vektör Kalkülüsü, Quaternion.Slerp | A* Pathfinding, Vector Calculus, Quaternion.Slerp |
| **İşitsel Dinamikler** | Unity AudioSource API — Uzamsal ses, Mesafeye dayalı interpolasyon | Unity AudioSource API — Spatial Audio, Distance-Based Interpolation |

---

## ⚙️ Sistemin Sunduğu Derin Mekanikler | Deep System Mechanics

### 1. Kestirimli Hedefleme ve İleri Vektör Matematiği | Predictive Targeting & Advanced Vector Math

**🇹🇷 Türkçe:**
Standart yapay zeka sistemleri hedefin geçmişini takip ederken, Project Hunter geleceği hesaplar. Avcının zihni, hedefin anlık hız vektörünü ($v = \frac{\Delta x}{\Delta t}$) ölçerek, avın bulunacağı noktayı zaman dilimi öncesinden hesaplar. Bu sayede rotası daima avın **arkasından gelmek** değil, avın yolunu kesmek üzere planlanır.

**🇬🇧 English:**
While standard AI systems track the target's past, Project Hunter calculates the future. The hunter's mind measures the target's instantaneous velocity vector ($v = \frac{\Delta x}{\Delta t}$) and predicts where the prey will be seconds ahead. Thus, its route is never to chase from behind, but to **intercept the prey's path**.

---

### 2. Bilişsel Hafıza (Object Permanence) ve Gerçek Görüş Açısı | Cognitive Memory & True Line-of-Sight

**🇹🇷 Türkçe:**
Sistem, basit 0 ve 1 mantığıyla çalışmaz. Avcının görüş açısı (`Physics.Raycast` destekli) fiziksel duvarların arkasını göremez. Ancak av, görüş açısından veya duyma menzilinden kaybolduktan sonra bile, avcı avın son görüldüğü noktada kalıp **beklemeye** başlar — gerçek bir yırtıcı hayvan gibi.

**🇬🇧 English:**
The system doesn't work with simple 0 and 1 logic. The hunter's line-of-sight (`Physics.Raycast` powered) cannot see through physical walls. However, even after the prey disappears from view or hearing range, the hunter remains at the last seen location and **waits** — like a real predator.

---

### 3. Kinetik Akıcılık (Kinematic Smoothing) ve Optimizasyon | Kinematic Smoothing & Performance Optimization

**🇹🇷 Türkçe:**
A* algoritmasının işlemciyi boğmasını ve "Pathfinding Paralysis" hatalarını engellemek için rota hesaplamaları her frame'de değil, **0.15 saniyelik aralıklarla** yapılır. Düşük performanslı cihazlarda bile sistem pürüzsüz çalışır.

**🇬🇧 English:**
To prevent A* from choking the CPU and avoid "Pathfinding Paralysis" errors, pathfinding calculations run at **0.15-second intervals** instead of every frame. The system runs smoothly even on low-end devices.

---

### 4. İşitsel Gerilim Yönetimi | Audio-Driven State Machine

**🇹🇷 Türkçe:**
Oyunun ses miksajı doğrudan yapay zekanın sinir sistemine bağlıdır. Avcı devriye modundayken sadece karakterin sinsi fısıltıları yankılanır. Hedef algılandığında ses şiddeti artar; çatışma başladığında, oyuncunun kalbi gibi hızlanan ritimik sesler çalar.

**🇬🇧 English:**
The game's audio mix is directly tied to the AI's nervous system. While patrolling, only subtle whispers echo. When the target is detected, sound intensity increases; during combat, rhythmic sounds beat like the player's racing heart.

---

## 👁️ Siber-Optik Test Ekranı (Tactical HUD) | Cyber-Optic Test Screen

Klasik `Debug.Log` konsol mesajları yerine, sistem Unity'nin `Handles` API'sini kullanan estetik bir Taktiksel Radar sunar.

Instead of classic `Debug.Log` console messages, the system features an aesthetic Tactical Radar using Unity's `Handles` API.

* **🇹🇷 Altın Görüş Konisi & Kan Kırmızısı Radar** | **🇬🇧 Golden Vision Cone & Crimson Radar:** Görsel ve işitsel algı alanları yarı saydam geometrik şekillerle izole edilir. / Visual and auditory perception fields are isolated with semi-transparent geometric shapes.

* **🇹🇷 Kestirimci Vektör (Predictive Line)** | **🇬🇧 Predictive Vector:** Hedefin hızına göre avcının pusu kuracağı koordinatları gerçek zamanlı gösteren siyan çizgiler. / Cyan dashed lines showing the intercept point in real-time.

* **🇹🇷 Yüzen Zihin Monitörü** | **🇬🇧 Floating Mind Monitor:** Avcının başının üzerinde beliren `[ AI CORE ]` paneli, sistemin anlık kararını ekrana yansıtır. / The `[ AI CORE ]` panel displays the AI's current state: `PATROLLING`, `HUNTING`, `TERMINATED`.

---

## 🚀 Hızlı Başlangıç & Kurulum Rehberi | Quick Start & Installation Guide

### 📋 Ön Gereksinimler | Prerequisites

* **Unity Hub & Motoru | Engine:** Unity 6000.x veya daha güncel / or newer
* **Git:** Projeyi klonlamak için / For cloning the project

### 🛠️ Kurulum Adımları | Installation Steps

**1. Zihni Klonlayın | Clone the Mind:**
```bash
git clone https://github.com/DioBey7/Project-Hunter-AI.git
```

**2. Motoru Başlatın | Launch the Engine:**
Unity Hub'ı açın, Add butonuna tıklayarak klonladığınız proje klasörünü seçin.
Open Unity Hub, click Add, and select the cloned project folder.

**3. Sahneyi Yükleyin | Load the Scene:**
Assets/Scenes klasöründen Main Scene dosyasını açın.
From Assets/Scenes folder, open the Main Scene file.

### 🔬 Test ve Gözlem | Testing & Observation

Play tuşuna basın ve şu deneyleri gerçekleştirin / Press Play and perform these experiments:

**🇹🇷 Deney 1 (İşitsel Gerilim)** | **🇬🇧 Experiment 1 (Audio Tension):**
Hedef objeyi sessiz bölgeden gürültülü bölgesine sürükleyin. Avcının etrafındaki radar büyüyerek kızarır.
Move the target from a quiet zone to a loud zone. The hunter's radar grows and turns red.

**🇹🇷 Deney 2 (Kestirimci Matematik)** | **🇬🇧 Experiment 2 (Predictive Math):**
Hedef objeyi hızlıca hareket ettirin. Avcının çizdiği rota sizin arkanızdan gelmediğini, hız vektörünüzü tahmin ettiğini göreceksiniz.
Move the target quickly. You'll see the hunter's path predicts your movement, not chasing behind.

**🇹🇷 Deney 3 (Deterministik Ölüm)** | **🇬🇧 Experiment 3 (Deterministic Death):**
Avcının Catch Radius içine girin. Sistem bitirici vuruş sesini çalıp simülasyonu sona erdirir.
Enter the hunter's Catch Radius. The system plays a fatal sound and terminates the simulation.

---

## 🎨 Kendi Oyununuza Entegrasyon | Integration into Your Game

Bu sistem, "Tak-Çalıştır" (Plug-and-Play) mantığıyla herhangi bir projeye entegre edilebilir. `ScriptableObjects` kullanılarak oluşturulan **Hunter Profile** sayesinde, kodda hiçbir değişiklik yapmadan avcının davranışını özelleştirebilirsiniz.

This system can be integrated into any project with "Plug-and-Play" logic. Using `ScriptableObjects`, the **Hunter Profile** allows you to customize the AI's behavior without changing any code.

### 1. Zihin Matrisini Kurmak | Setting Up the Grid

🇹🇷 Sahnenize boş bir obje açın ve `GridManager.cs` scriptini ekleyin. Haritanızın boyutlarına göre Grid sınırlarını belirleyin.

🇬🇧 Create an empty GameObject in your scene and attach `GridManager.cs`. Define grid boundaries based on your map size.

### 2. Avı İşaretlemek | Marking the Prey

🇹🇷 Oyuncu karakterinize `TargetTracker.cs` scriptini ekleyin. Bu yapı, oyuncunun hız vektörünü avcının zihnine iletir.

🇬🇧 Attach `TargetTracker.cs` to your player character. This script transmits the player's velocity vector to the AI's mind.

### 3. Avcıyı Yaratmak | Creating the Hunter

🇹🇷 Kendi 3D model/canavar modeline `HunterAI.cs` scriptini ekleyin. Target ve Target Tracker yuvaları oyuncunuzu gösterecek şekilde ayarlayın.

🇬🇧 Attach `HunterAI.cs` to your 3D model. Set the Target and Target Tracker slots to reference your player.

### 4. Zihni Şekillendirmek | Shaping the AI's Mind

🇹🇷 Sağ tıklayıp `Create -> AI -> Hunter Profile` seçerek yeni bir Hunter Profile oluşturun. Avcının hızı, görüş açısı (FOV), duyma menzili ve seslerini ayarlayın.

🇬🇧 Right-click and select `Create -> AI -> Hunter Profile`. Configure speed, FOV angle, hearing range, and audio files.

Artık avcınız otonom olarak devriye gezmeye, engellerin etrafından dolanmaya ve avını avlamaya tamamen hazır!

Your hunter is now ready to patrol autonomously, navigate around obstacles, and hunt prey!

---

## 📫 İletişim & Ağ | Contact & Network

Sektördeki profesyonellerle tanışmaktan, geri bildirim almaktan ve yaratıcı işbirliklerinden hoşlanırım.

I enjoy meeting professionals, receiving feedback, and creating collaborations.

* **LinkedIn:** [www.linkedin.com/in/beyza-yazıcı-400183332](https://www.linkedin.com/in/beyza-yazici-400183332)
* **E-Posta | Email:** beyza04yazici2005@gmail.com
* **GitHub:** [github.com/DioBey7](https://github.com/DioBey7)

---

## 📄 Lisans | License (MIT)

Bu proje **MIT Lisansı** ile korunmaktadır ve açık kaynaklıdır.

This project is protected under the **MIT License** and is open source.

🇹🇷 Tüm kodları, mimariyi ve sistem tasarımını kopyalamakta, değiştirmekte ve kendi kişisel veya ticari oyun projelerinizde kullanmakta tamamen özgürsünüz. Tek şart, orijinal yazarı (BEYZA YAZICI) kredi listesinde belirtmenizdir.

🇬🇧 You're free to copy, modify, and use all code, architecture, and system design in your personal or commercial game projects. The only requirement is to credit the original author (BEYZA YAZICI) in the credits.

---

<div align="center">
  <p><strong>Made with 💜 and Vector Math</strong></p>
</div>
