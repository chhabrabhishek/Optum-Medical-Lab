# Optum-Medical-Lab
Describing the human anatomay using Augmented Reality. Made for Optum Global Hackathon 2021.

## Video of working [Demo](https://optum.video.uhc.com/media/OPTUM+MEDICAL+LAB+%28Legen-waitforit-dary%29/1_bzm2ktt0)

## Setting up and running the project
- Prerequisites
    1. A working machine with Unity installed (Preferable Version 2020.3.14f1 LTS). All versions are supported otherwise.
    2. Printed image targets for the models to be shown over. You can find the 2 images from [here](https://github.com/chhabrabhishek/Optum-Medical-Lab/tree/main/Assets/Images).
    3. Android SDK, Android NDK and Java JDK installed (If wants to be deployed on Android devices).
    4. Unity must include IOS support package (If wants to be deployed on I-Phone devices).
- Clone the project in your local workspace.
- Open the project using Unity Hub or directly with Unity.
- Running the program inside Unity itself.
    1. You must have a webcam (integrated or externally attached) for capturing the image targets.
    2. Click on the run button and project your camera to the printed real world image targets.
    3. Click the virtual buttons on the targets.
    4. The respective model will start floating over the target.
- Running the program inside android devices.
    1. Go to build settings and change your platform to Android.
    2. Set the path for SDK, NDK and JDK (if not already set).
    3. Connect your device using a USB cable and click on "Build and Run" (It will automatically install the apk file and run it on your device).
    4. You can also just click on "Build", which will create a APK file. You can copy that APK file into your device and install it manually to run the project.
    5. After you run the application on your device, project it over the printed image targets and click the virtual buttons for the 3d Human Anatomical models to show up.

## Running the project, without setting anything up.
- Prerequisites
    1. An android device with a working camera.
    2. Printed image targets for the models to be shown over. You can find the 2 images from [here](https://github.com/chhabrabhishek/Optum-Medical-Lab/tree/main/Assets/Images).
- Download the APK file from [here](https://github.com/chhabrabhishek/Optum-Medical-Lab/raw/main/Apks/Optum%20Medical%20Lab.apk).
- Copy and install this APK into your android device.
- Run the application and start projecting it over the printed image targets 
- Click the virtual buttons for the 3d Human Anatomical models to show up.
