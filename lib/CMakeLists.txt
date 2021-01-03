cmake_minimum_required(VERSION 3.0)
project(pantilt)
add_library(pantilt SHARED PCA9685_servo_driver.c PCA9685_servo_driver.h bcm283x_board_driver.c bcm283x_board_driver.h sccb_bus.c sccb_bus.h)