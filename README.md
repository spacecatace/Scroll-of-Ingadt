# Scroll of Ingadt
A simple group game project for the Turku University course Introduction to Game Development Tools

## Projektin kopioiminen Unityyn _(teoriassa)_
Tämä repo itsessään ei riitä suoraksi Unity-projektiksi, joten sen sisältö sellaisenaan ei toimi Unityssä suoraan.
1. Asenna Unity **2022.3.11f1**
2. Luo uusi tyhjä 2D Core Unity-projekti ja seuraa [näitä nopeita ohjeita](https://docs.unity3d.com/Manual/Quickstart2DSetup.html)
3. Esivalmistele Git LFS sekä Git ja Unity yhteiskäyttö
   - Seuraa askelia [tässä artikkelissa](https://medium.com/@linojon/git-and-unity-getting-started-ad7c42be8324) otsikkoon _Making your first commit_ asti (sen jälkeen tulee vain Git-ohjeita). **Älä suorita committeja vielä.**
4. Tuo GitHub-repon tiedostot omaan projektiisi
   - Yksinkertaisin tapa on ladata repon zip-tiedosto suoraan GitHubista vihreästä _Code_-napista ja korvata oman paikallisen projektin sisältö zipin sisällöllä ylikirjoittaen.
   - Vaihtoehtoisesti voi Gitillä kloonata repon omalle koneelle ensin tyhjään kansioon ja siirtää sieltä paikallisen Unity-projektin päälle, sallien korvaamisen.
   - Kolmas vaihtoehto on määrittää tämä GitHub `origin remote`:ksi paikallisen Unity-projektinsa repoon ja sen kautta [hakea ja tuoda muutokset](https://www.atlassian.com/git/tutorials/syncing).
5. Muutoksia voi sitten helposti seurata ja hakea mm. useimpien IDE:n tai [GitHub Desktopin](https://desktop.github.com/) kautta

**Jos käytät muita IDE:tä kuin Visual Studio Code, käythän lisäämässä siihen generoidut rivit [.gitignore](/.gitignore)-tiedostoon [täältä](https://www.toptal.com/developers/gitignore).**

## Projektissa käytetyt Unity-paketit
Siltä varalta, että paketteja joutuu itse asentamaan ennen projektin tuontia:
- 2D (package): _com.unity.feature.2d_
- Cinemachine: _com.unity.cinemachine_
- Input System: _com.unity.inputsystem_
- JetBrains Rider Editor: _com.unity.ide.rider_
- Test Framework: _com.unity.test-framework_
- TextMeshPro: _com.unity.textmeshpro_
- Timeline: _com.unity.timeline_
- Unity UI: _com.unity.ugui_
- Universal RP: _com.unity.render-pipelines.universal_
- Version Control: _com.unity.collab-proxy_
- Visual Scripting: _com.unity.visualscripting_
- Visual Studio Editor: _com.unity.ide.visualstudio_
