# Appodeal Tech Test – Unity UI Demo

##  Project Overview

This Unity project demonstrates a minimal yet functional UI system featuring a `Play` button, `Slider`, `Text`, and an `AudioSource`. When the Play button is clicked, a loading animation is triggered, the slider fills over time, a percentage label is updated live, and a sound effect is played. The button itself also features a simple scale animation on click to enhance user feedback.

---

##  Project Structure

```
Assets/
├── Scenes/
│   └── DemoScene.unity          # Main scene with UI elements
├── Scripts/
│   └── PlayButtonUI.cs          # Handles UI logic and animations
```

###  Scene Components

- `Canvas` (UI Root)
  - `Play Button`: Triggers the slider animation and plays audio
  - `Loading Slider`: Fills from 0% to 100% over time
  - `Progress Text`: Displays percentage ("Loading... 30%", then "Done")
  - `AudioSource`: Plays when loading starts

---

##  How It Works

- When the Play button is clicked:
  1. The button scales up briefly and scales back (custom animation).
  2. The slider starts to fill over 3 seconds.
  3. The percentage is shown in real time on the text element.
  4. An audio clip is played using `AudioSource`.

No external packages (e.g., DOTween) are used. All logic is handled via coroutines and Unity built-in components.

---

##  Pipeline Suggestions

-  Git version control is set up with proper `.gitignore` for Unity.
-  For scalability, Unity Test Framework could be integrated for UI validation.
-  GitHub Actions or Unity Cloud Build can be introduced for CI/CD automation.

---

##  UI/UX Improvement Ideas

- Replace `Text` with **TextMeshPro** for modern UI rendering.
- Add hover/click **visual cues** for buttons (e.g., color, glow).
- Include **loading icons or animation** for better feedback.
- Group UI in a clean hierarchy for modularity and scalability.

---

##  Performance Notes

- Uses `Coroutine` instead of `Update()` for timed operations.
- Keeps canvas hierarchy flat to optimize draw calls.
- No dynamic object creation—fully static for better runtime performance.
- Scene is lightweight and responsive on mobile targets.

---

##  Dependencies

- Unity 2020.3 or later (tested)
- No third-party plugins used
- All functionality built using Unity's native API

---

##  Setup Instructions

1. Open the project in Unity.
2. Open `DemoScene.unity` from `Assets/Scenes/`.
3. Assign all required references (`Button`, `Slider`, `Text`, and `AudioSource`) in the Inspector for the `PlayButtonUI` component.
4. Press Play to test.

---

##  Author

Prepared for **Appodeal Technical Artist Test**  
By: *Jahanzaib Rehman*  
Date: *July 16, 2025*