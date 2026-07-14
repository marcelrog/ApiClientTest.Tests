pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Install Node') {
            steps {
                sh 'curl -fsSL https://deb.nodesource.com/setup_20.x | sudo -E bash -'
                sh 'sudo apt-get install -y nodejs'
            }
        }
    }
}
