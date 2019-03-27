#!/usr/bin/env groovy

pipeline {
    agent { 
        label 'kvm-win10build'
    }
	
    options {
        disableConcurrentBuilds()
    }

    stages {
        stage('Build') {
            steps {
                bat 'MSBuild.exe -t:restore'
            }
        }
    }
}