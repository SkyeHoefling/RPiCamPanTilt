# Configure our Required Version
cmake_minimum_required(VERSION 3.0)

# Define the name of our project
project(pantilt)

# Define the output library to be a shared file (.so or .dll) and output it as "(lib)hello-cpp.so"
add_library(pantilt SHARED PCA9685_servo_driver.c PCA9685_servo_driver.h bcm283x_board_driver.c bcm283x_board_driver.h sccb_bus.c sccb_bus.h)