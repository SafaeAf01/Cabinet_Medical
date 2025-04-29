# Cabinet Médical - Application de Gestion

Cette application Windows Forms permet la gestion complète des patients, médecins et consultations d'un cabinet médical.

## Informations sur le projet

- **Développeur** : SAFAE AFOURAOU
- **Institution** : Faculté des Sciences Fès - Université Sidi Mohamed Ben Abdellah
- **Formation** : Master Ingénierie Smart Systèmes, Réseaux et Gestion de Projets (ISSRGP)
- **Module** : CSHARP
- **Enseignant** : Younes LAKHRISS

## Fonctionnalités principales

- **Gestion des patients** :
  - Ajout de patients à la liste d'attente
  - Retrait de patients de la liste d'attente
  - Affichage des patients par différents critères (spécialité, âge, sexe)
  - Identification du patient prioritaire

- **Gestion des médecins** (extension) :
  - Ajout, modification et suppression de médecins
  - Association de médecins à des spécialités

- **Gestion des consultations** (extension) :
  - Planification de consultations entre patients et médecins
  - Enregistrement de diagnostics et notes
  - Suivi des coûts des consultations

- **Fonctionnalités diverses** :
  - Interface avec menus déroulants
  - Ajout dynamique de spécialités médicales
  - Interface utilisateur intuitive

## Comment utiliser l'application

1. **Pour compiler avec Visual Studio:**
   - Ouvrez Visual Studio
   - Sélectionnez "Ouvrir un projet ou une solution"
   - Naviguez vers le dossier du projet et sélectionnez le fichier CabinetMedical.csproj
   - Cliquez sur "Démarrer" (F5) pour compiler et exécuter l'application

2. **Pour compiler avec Visual Studio Code:**
   - Installez l'extension "C#" de Microsoft
   - Ouvrez le dossier du projet dans VS Code
   - Utilisez la commande "Build" ou "Run" depuis le menu supérieur

3. **Pour compiler avec MSBuild directement:**
   - Ouvrez un terminal en tant qu'administrateur
   - Naviguez vers le répertoire du projet
   - Exécutez: `"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" CabinetMedical.csproj`
   - L'exécutable se trouvera dans le dossier bin\Debug\net6.0-windows

## Structure du Projet

- **Models/** - Classes de base de l'application
  - `Patient.cs` - Modèle pour les patients
  - `Cabinet.cs` - Classe principale gérant les patients, médecins et consultations
  - `Medecin.cs` - Modèle pour les médecins (extension)
  - `Consultation.cs` - Modèle pour les consultations (extension)

- **Forms/** - Interfaces graphiques
  - `FormPrincipal.cs` - Interface principale
  - `FormAffichage.cs` - Fenêtre pour afficher les informations
  - `FormMedecin.cs` - Interface de gestion des médecins (extension)
  - `FormConsultation.cs` - Interface de gestion des consultations (extension)

## Fonctionnalités de l'interface utilisateur

- **Menu principal** - Accès aux différentes fonctionnalités :
  - Gestion des médecins
  - Gestion des consultations
  - Ajout de spécialités
  - À propos de l'application

- **Gestion des patients** :
  - Formulaire d'ajout avec validation
  - Liste d'attente interactive
  - Visualisation par catégories

## Extensions implémentées

1. **Classes supplémentaires** :
   - Classe `Medecin` avec attributs (nom, prénom, spécialité, consultations)
   - Classe `Consultation` avec attributs (date, patient, médecin, diagnostic, notes, coût)

2. **Interface graphique améliorée** :
   - Menus déroulants pour une navigation plus intuitive
   - Formulaires dédiés pour la gestion des médecins et consultations
   - Interface cohérente et moderne

## Caractéristiques techniques

- Développé en C# avec .NET Framework
- Architecture orientée objet
- Interface utilisateur Windows Forms
- Gestion des erreurs et validation des données
- Organisation modulaire du code

## Développé selon les spécifications du document "C Sharp_Projet_CabinetMediacal.pdf" avec l'implémentation des extensions proposées
