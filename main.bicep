resource containerGroup 'Microsoft.ContainerInstance/containerGroups@2023-05-01' = {
  name: 'blazor-learning'
  location: resourceGroup().location
  properties: {
    containers: [
      {
        name: 'blazor-learning'
        properties: {
          image: 'docker.io/randongg/blazor-learning:latest'
          ports: [
            {
              port: 80
              protocol: 'TCP'
            }
          ]
          resources: {
            requests: {
              cpu: 1
              memoryInGB: 2
            }
          }
        }
      }
    ]
    osType: 'Linux'
    restartPolicy: 'Always'
    ipAddress: {
      type: 'Public'
      ports: [
        {
          port: 80
          protocol: 'TCP'
        }
      ]
    }
  }
}
