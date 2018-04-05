# CarGarage

Contributor: Mulot Iliès

## App Context

The goal is to reproduce a simple car garage behavior : 

**Customer**
* Be able to register/sign in to the site.
* Be able to take an appointment from the site.
* Be aware of your car's repair state.
* Be aware of the remaining time of the repair to be done.

**Workers**
* Can handle 1 task per worker.
* Can work beside other workers.
* Once a task is finished, tell the secretary that is done.
* Be able to retrieve a new task when the old one is done.
* Be able to communicate at anytime with the secretary.
* If there is nothing to do because there is no work in queue, wait.
* The number of worker can be changed.

**Secretary**
* Must put any new appointment in the workers queue.
* Tell the client when his car's repair is done.
* Tell the client about his car's repair state.
* Keep a trace of any operation in case of complaints.
* Register each worker's load at the end of the day.

## Involved technologies/concept
* EntityFramework with Code-First approach.
* .Net Framework 4.6.1
* MultiThreading/Thread Pool
* Asynchronous task
