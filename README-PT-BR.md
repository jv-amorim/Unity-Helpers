<h1 align="center">
    Unity Helpers
</h1>

<p align="center">
    <img alt="Unity Official Logo" src="https://github.com/JV-Amorim/Unity-Helpers/blob/master/Official_unity_logo.png" width="30%">
</p>

<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/JV-Amorim/Unity-Helpers">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/JV-Amorim/Unity-Helpers">

  <a href="https://github.com/JV-Amorim/Unity-Helpers/commits/master">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/JV-Amorim/Unity-Helpers">
  </a>

  <img alt="License" src="https://img.shields.io/badge/license-MIT-brightgreen">
</p>

<p align="center">
  <a href="https://github.com/JV-Amorim/Unity-Helpers/blob/master/README.md">🇬🇧 EN<a/> |
  <a href="https://github.com/JV-Amorim/Unity-Helpers/blob/master/README-PT-BR.md">🇧🇷 PT-BR<a/>
</p>

## Tabela de Conteúdos

- [Tabela de Conteúdos](#tabela-de-conte%C3%BAdo)
- [Descrição](#descri%C3%A7%C3%A3o)
- [Conteúdo](#conte%C3%BAdo)
  - [Camera Helpers](#camera-helpers)
  - [Canvas Helpers](#canvas-helpers)
  - [Email Helpers](#email-helpers)
  - [Extensions](#extensions)
  - [File Helpers](file-helpers)
  - [GameObject Helpers](gameobject-helpers)
  - [Hashing Helpers](hashing-helpers)
  - [Http Helpers](http-helpers)
  - [Scene Helpers](scene-helpers)
  - [String Helpers](string-helpers)
  - [Texture Helpers](texture-helpers)
  - [Virtual Keyboard Helpers](virtual-keyboard-helpers)
  - [XML Helpers](xml-helpers)
- [Como Utilizar](#como-utilizar)
- [Como Contribuir](#como-contribuir)
- [Licença](#licen%C3%A7a)

## Descrição

Um conjunto de scripts Unity em C# que podem ser úteis em diversos projetos diferentes.

## Conteúdo

Existem três tipos de classes neste repositório: classes que herdam de MonoBehaviour, classes que não herdam de MonoBehaviour (e são estáticas) e classes com métodos de extensão. As classes do segundo e terceiro tipo podem ser usadas normalmente, isto é, podem ser usadas da forma normal em que classes estáticas e classes com métodos de extensão são usadas. Entretanto, o primeiro tipo de classes (classes que herdam de MonoBehaviour) precisam ser anexadas como component de um GameObject para, assim, os seus métodos poderem ser utilizados.

### Camera Helpers

- **Screenshot.cs**: Classe com métodos para capturar screenshots a partir da visão da câmera no jogo.

### Canvas Helpers

- **CanvasEffects.cs**: Classe com métodos que criam efeitos e notificações no canvas selecionado. Com essa classe você pode criar um alerta na tela com um certo tempo de duração, por exemplo.

- **CanvasEffectsWithDelay.cs**: Parecido com o  CanvasEffects.cs, esse script contém métodos que criam efeitos e notificações no canvas selecionado. Entretanto, os métodos dessa classe podem receber como parâmetro um tempo que atrase a sua execução.

- **CanvasItemsPaginationManager.cs**: Classe que cria paginação em um conjunto de items de canvas. Exemplos de conjuntos de items de canvas: galeria de imagens, tabela de ranking de pontuação.

- **CursorEffects.cs**: Classe com métodos que mudam o cursor do mouse do ícone de seta para o ícone de link, e vice-versa. Para usar essa classe e mudar o cursor do mouse ao passar em cima de um elemento do canvas (como um botão, por exemplo), você precisa anexar esse script à um GameObject e atribuir a textura de seta e a textura de link aos dois campos públicos. Os métodos ChangeCursorToArrow() e ChangeCursorToLink() podem ser chamados com um EventTrigger, utilizando os event listeners OnPointerEnter e OnPointerExit.

- **InputFieldHelpers.cs**: Classe com métodos para utilizar no component de InputField ou TMP_InputField. Com essa classe você pode mostrar or ocultar o conteúdo de um campo de senha, por exemplo.

- **ScrollbarButtons.cs**: Classe com métodos que permitem o uso de botões para controlar uma scrollbar.

### Email Helpers

- **EmailSender.cs**: Classe que permite o envio assíncrono de mensagens de email para um endereço de email. A mensagem de email é criada utilizando o modelo EmailMessage.

- **EmailMessage.cs**: Modelo EmailMessage.

- **EmailValidator.cs**: Classe com métodos que validam se um endereço de email é valido.

### Extensions

- **ArrayExtensions.cs**: Classe com métodos de extensão para arrays de tipos genéricos. Métodos: Shuffle.

- **RectTransformExtensions.cs**: Classe com métodos de extensão que permitem redimensionar elementos do canvas facilmente utilizando código C#. Métodos: SetLeft, SetRight, SetTop, SetBottom.

- **TextureExtensions.cs**: Classe com métodos de extensão para objetos do tipo Texture2D. Métodos: MergeTextures, AddWatermark, ToTexture2D.

- **TransformExtensions.cs**: Classe com métodos de extensão para componentes do tipo Transform. Métodos: FindChildrenGameObjectsWithTag.

### File Helpers:

- **FileManagementHelpers.cs**: Classe com métodos para copiar e apagar arquivos. Também possui um método que permite criar um nome único para um arquivo que será copiado para algum diretório, evitando a sobrescrita de algum arquivo já existente.

### GameObject Helpers:

- **GameObjectInstantiator.cs**: Classe que permite a instanciação de GameObjects na cena durante a execução do jogo.

### Hashing Helpers:

- **HashGenerator.cs**: Classe com um método que permite a criação de hashs criptográficos SHA256 a partir de uma string.

### Http Helpers:

- **ApiDataRequester.cs**: Classe que permite o solicitação de dados de uma API.

- **ApiDataSender.cs**: Classe que permite o envio de dados para uma API.

### Scene Helpers:

- **SceneManager.cs**: Classe com métodos para o gerenciamento de cenas.

### String Helpers:

- **StringGenerator.cs**: Classe com métodos que permitem a criação de string randômicas.

### Texture Helpers:

- **TextureEditor.cs**: Classe com métodos para edição de Textures, como recortes, por exemplo.

- **TextureLoader.cs**: Classe com métodos que permitem a obtenção de uma Texture a partir de um arquivo ou URL.

- **TextureScale.cs**: Classe com métodos que permitem o redimensionamento de uma Texture. Na maioria dos caso, apenas a utilização do método `public static void Bilinear(Texture2D tex, int newWidth, int newHeight)` é suficiente. [Esse script foi obtido na Unity Community Wiki](https://wiki.unity3d.com/index.php/TextureScale).

### Virtual Keyboard Helpers:

(APENAS PARA WINDOWS)

- **VirtualKeyboard.cs**: A classe permite abrir e fechar o teclado virtual do Windows 10.

### XML Helpers:

- **XMLReader.cs**: A classe permite a leitura do conteúdo de um arquivo XML. O método `GetDataFromXMLFile(string path, string xmlTag)` obtém o conteúdo delimitado por uma tag XML. Exemplo: `<Username>Luke Skywalker</Username>`. Esse método não funciona em tags que são filhas de outras tags.

---

## Como Utilizar

1. Copie/importe todas as pastas desse repositório (ou apenas as pastas de scripts que você deseja utilizar) para a pasta de Assets.
2. Importe o namespace dos scripts com os recursos que você deseja utilizar no seu script. Exemplo: adicione `using UnityHelpers.CanvasHelpers;` no topo do seu código para utilizar as classes e métodos do namespace CanvasHelpers.

## Como Contribuir

Para contribuir neste projeto:

- Faça uma fork desse repositório;
- Crie uma branch com sua nova feature: `git checkout -b my-feature`;
- Dê um commit nas suas mudanças: `git commit -m 'feat: 'My feature details'`.
- Dê um push dos commits para a sua branch: `git push origin my-feature`.

Depois que o merge do seu pull request for feito, você pode deletar sua branch.

## Licença

Distribuído sob a licença MIT. Veja a página da [licença](https://opensource.org/licenses/MIT) para mais informações.
