# Echo Shot VR

Bienvenue dans **Echo Shot VR**, un projet immersif qui combine exploration, interaction en réalité virtuelle, et un système de tir réaliste avec des ennemis et des cibles. Ce projet est conçu pour le casque **Meta Quest 2** et utilise **Unity** comme moteur de développement.

---

## 🎯 **Fonctionnalités principales**

### 1. **Navigation en VR**
- Déplacement libre dans un environnement 3D.
- Interaction intuitive avec des objets comme des portes, fenêtres, et placards.

### 2. **Ennemis dynamiques**
- Un ennemi humain armé qui patrouille et attaque lorsqu'il détecte le joueur.
- Détection basée sur le champ de vision et la distance.

### 3. **Cibles interactives**
- Des cibles murales avec zones de points :
  - Cercle blanc : **10 points**
  - Cercle vert : **30 points**
  - Cercle rouge : **50 points**
  - Point central bleu : **75 points**
- Système d'impacts de balles persistant avec affichage des marques sur les surfaces.

### 4. **Système de score**
- Calcul en temps réel des points gagnés.
- Affichage d'un score global sur une interface utilisateur en VR.

---

## 🚀 **Installation et configuration**

### Prérequis
- Unity version **2022.3.50f1** ou supérieure.
- Casque **Meta Quest 2** configuré pour le développement.
- SDK Oculus intégré dans Unity.

### Étapes d'installation
1. Clonez ce dépôt sur votre machine :
   ```bash
   https://github.com/dosleam/Project-DemoDay.git
   ```
2. Ouvrez le projet dans Unity.
3. Assurez-vous que le **XR Plugin Management** est activé dans les paramètres de projet.
4. Configurez le **Player Settings** pour activer l'Oculus comme cible de build.
5. Branchez votre casque VR et lancez le mode Play pour tester.

---

## 🕹️ **Gameplay**

### Navigation
- **Joystick gauche** : Déplacement du joueur.
- **Joystick droit** : Rotation de la vue.
- **Grip** : Saisir des objets (Situé sur le côté de la manette).
- **Gâchette** : Sélectionner des objets dans votre environnement (située à l’avant de la manette).

### Tir
- **Gâchette droite** : Tirer.
- **Gâchette gauche** : Viser.

### Recharge
- Saisir le chargeur de l'arme pour le sortir et le remplacer par un nouveau chargeur situé sur votre ceinture.

### Système de score
- Les points s'affichent en haut à gauche de l'interface.
- Chaque impact de balle sur une cible incrémente le score global selon la zone touchée.

---

## 🛠️ **Structure du projet**

### Scripts principaux
- `PlayerController.cs` : Gestion des déplacements et interactions du joueur.
- `EnemyPatrol.cs` : Mouvement des ennemis entre des points prédéfinis.
- `EnemyDetection.cs` : Détection du joueur et gestion des attaques.
- `TargetZone.cs` : Gestion des impacts sur les cibles et attribution des points.
- `ScoreManager.cs` : Système centralisé pour le calcul et l'affichage du score.

### Préfabriqués
- **Ennemis** : Modèle avec comportement de patrouille et d'attaque.
- **Balles** : Préfabriqué avec effet visuel et système de collision.
- **Impacts** : Préfabriqué pour afficher des marques persistantes sur les surfaces.
- **Cibles** : Zones de score prédéfinies avec différents points.

---

## 🌟 **Améliorations futures**
- Ajouter des niveaux avec des objectifs variés.
- Implémenter un mode multijoueur compétitif.
- Ajouter un système de dégâts pour le joueur et les ennemis.
- Introduire différents types d'armes et de munitions.

---

## 🖼️ **Aperçu visuel**
![Capture d'écran 2025-01-24 093225](https://github.com/user-attachments/assets/9581c581-16be-4bf8-b989-7b3827db46a9)
![Capture d'écran 2025-01-24 093241](https://github.com/user-attachments/assets/768eb7bf-c4db-4493-92cf-abf6b94aa869)
![Capture d'écran 2025-01-24 093306](https://github.com/user-attachments/assets/51677c0b-42a1-455d-a65d-06c2360ff931)
![Capture d'écran 2025-01-24 093201](https://github.com/user-attachments/assets/65a93366-fa67-4c1c-bea6-492baa299095)
![Capture d'écran 2025-01-24 093347](https://github.com/user-attachments/assets/17ac73c8-5fcd-4577-9e96-a129dac65c7c)
![Capture d'écran 2025-01-24 093706](https://github.com/user-attachments/assets/4bfafc33-1b36-4c25-aa3f-bcd1704c6a80)


---

## 📜 **Créateur du projet**

- Jérémy Sousa (Github: [dosleam](https://github.com/dosleam))
- Florian Bombeeck (Github: [Pandor3](https://github.com/Pandor3))
