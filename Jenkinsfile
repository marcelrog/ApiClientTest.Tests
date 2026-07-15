pipeline {
    agent any

    tools {
        nodejs 'Node20'
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Verify Node') {
            steps {
                bat 'node -v'
                bat 'npm -v'
            }
        }

        stage('Install Playwright') {
            steps {
                bat 'npm install -D @playwright/test'
                bat 'npx playwright install'
            }
        }

 stage('Run Playwright Tests') {
    steps {
        bat 'npx playwright test --reporter=html'
    }
}

stage('Archive Report') {
    steps {
        archiveArtifacts artifacts: 'playwright-report/**', fingerprint: true
    }
}

 stage('Publish Report') {
    steps {
        publishHTML(target: [
            allowMissing: false,
            alwaysLinkToLastBuild: true,
            keepAll: true,
            reportDir: 'playwright-report',
            reportFiles: 'index.html',
            reportName: 'Playwright Report'
                ])
            }
        }
        stage('Copy Report') {
    steps {
        bat 'xcopy /E /I playwright-report C:\\Jenkins\\reports\\playwright-report'
    }
}

    }
}
